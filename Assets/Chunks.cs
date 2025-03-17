using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunks : MonoBehaviour
{
    [SerializeField] List<Transform> pivotes = new List<Transform>();
    [SerializeField]    List<GameObject> obstaculosGuardados = new List<GameObject>();
    [SerializeField] bool verificarAlIniciar;

    private void Start()
    {
        if(verificarAlIniciar == true)
        {
            GenerarObstaculos();
        }
        
    }
    public void GenerarObstaculos()
    {

        DestruirEnemigos();
        for (int i = 0; i < pivotes.Count; i++)
        {
            int numeroAleatorio = Random.Range(1,6);
            GameObject enemigo = (GameObject)Instantiate(Resources.Load("enemigo " + numeroAleatorio), pivotes[i]);
            enemigo.transform.localPosition = Vector3.zero;
            obstaculosGuardados.Add(enemigo);
        }
    }

    public void DestruirEnemigos()
    {
        for(int i = 0; i < obstaculosGuardados.Count; i++)
        {
            Destroy(obstaculosGuardados[i]);
        }
            obstaculosGuardados.Clear();
    }

    
}
