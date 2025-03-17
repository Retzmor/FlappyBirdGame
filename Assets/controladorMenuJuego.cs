using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class controladorMenuJuego : MonoBehaviour
{

    
    public int puntajeMaximo = 0;

    [SerializeField] TextMeshProUGUI textoPunto, scoreFinal, scoreMaximo;
    private void OnEnable()
    {
        ControladorPuntos.Instance.PuntosActalizados += ActualizarPuntajeTexto;
    }

    private void OnDisable()
    {
        ControladorPuntos.Instance.PuntosActalizados -= ActualizarPuntajeTexto;
    }

    void Start()
    {

        puntajeMaximo = PlayerPrefs.GetInt("PuntajeMaximo", 0);
        scoreMaximo.text = puntajeMaximo.ToString();
    }
    public void ActualizarPuntajeTexto(int puntaje)
    {
        
        textoPunto.text = puntaje.ToString();
        scoreFinal.text = puntaje.ToString();
        

        if (puntaje > puntajeMaximo)
        {

            Debug.Log("Dat guardad");
            puntajeMaximo = puntaje;
            PlayerPrefs.SetInt("PuntajeMaximo", puntajeMaximo);
            PlayerPrefs.Save(); 
            scoreMaximo.text = puntajeMaximo.ToString();
        }


   

    }
}
