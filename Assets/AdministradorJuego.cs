using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AdministradorJuego : MonoBehaviour
{
    // Start is called before the first frame update
   
    public static AdministradorJuego Instance;
    public delegate void EstadoDeJuego();
    public EstadoDeJuego MenuIniciado, MenuPausado, MenuReanudado, MenuFinalizado, SinPanel;

    public bool esReinicioRapido = false;


    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }

        else
        {
            Destroy(gameObject);
        }
    }

    public void Start()
    {
        Time.timeScale = 0;

        
    }



    public void IniciarJuego()
    {
        
        Time.timeScale = 1;
        MenuIniciado?.Invoke();
    }

    public void PausarJuego()
    {
        Time.timeScale = 0;
        MenuPausado?.Invoke();
    }

    public void ReanudarJuego()
    {
        Time.timeScale = 1;
        MenuReanudado?.Invoke();
    }

    public void ReiniciarJuego()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void VolverJuego()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        IniciarJuego();



    }

    public void FinalizarJuego()
    {
        Time.timeScale = 0;
        MenuFinalizado?.Invoke();
    }

    public void CerrarJuego()
    {
        Application.Quit();
    }
    
}
