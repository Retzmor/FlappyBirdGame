using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SumarPuntos : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) {

            Debug.Log("Punto");
            ControladorPuntos.Instance.SumarPunto();
            

        }
    }
      
}

