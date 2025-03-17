using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPuntos : MonoBehaviour
{
    public static ControladorPuntos Instance;

    public delegate void PuntosActualizadosDelegado(int puntajeActual);
    public PuntosActualizadosDelegado PuntosActalizados;

    int puntosActuales = 0;

    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        else
        {
            Destroy(gameObject);
        }
    }

    public void SumarPunto()
    {
        puntosActuales++;
        PuntosActalizados?.Invoke(puntosActuales);
    }
}
