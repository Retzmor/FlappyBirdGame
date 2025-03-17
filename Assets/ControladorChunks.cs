using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorChunks : MonoBehaviour
{
    [SerializeField] Transform UltimoChunk;
    [SerializeField] float velocidad;
    public List<Chunks> chunks = new List<Chunks>();
     
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < chunks.Count; i++)
        {
            chunks[i].transform.Translate(Vector3.left * velocidad * Time.deltaTime, Space.World);

            if (chunks[i].transform.position.x <= -6)
            {
                chunks[i].transform.position = UltimoChunk.transform.position + (Vector3.right * 6);

                UltimoChunk = chunks[i].transform;
                chunks[i].GenerarObstaculos();
            }
        }
    }
}
