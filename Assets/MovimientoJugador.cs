using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    Rigidbody2D rb;
    public float fuertzaSalto;
    
    

    public Animator animator;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public void saltar()
    {
        
        rb.velocity = new Vector2(0, fuertzaSalto);
        animator.SetTrigger("Salto");
        

    }

    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        AdministradorJuego.Instance.FinalizarJuego();
    }



    // Update is called once per frame
    void Update()
    {
        if (rb.position.y < -5)
        {
            AdministradorJuego.Instance.FinalizarJuego();
        }
    }

    
}
