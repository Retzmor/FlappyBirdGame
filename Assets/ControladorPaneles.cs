using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPaneles : MonoBehaviour
{
    [SerializeField] GameObject menuPausa, menuJuego, menuPrincipal, menuRespawn;

    public void OnEnable()
    {
        AdministradorJuego.Instance.MenuIniciado += MostrarPanelJuego;
        AdministradorJuego.Instance.MenuPausado += MostrarPanelPausa;
        AdministradorJuego.Instance.MenuReanudado += MostrarPanelGameOver;
        AdministradorJuego.Instance.MenuFinalizado += MostrarPanelFinalizado;
        AdministradorJuego.Instance.SinPanel += PanelDesactivados;


    }

    public void OnDisable()
    {
        AdministradorJuego.Instance.MenuIniciado -= MostrarPanelJuego;
        AdministradorJuego.Instance.MenuPausado -= MostrarPanelPausa;
        AdministradorJuego.Instance.MenuReanudado -= MostrarPanelGameOver;
        AdministradorJuego.Instance.MenuFinalizado -= MostrarPanelFinalizado;
       
    }

    public void MostrarPanelJuego()
    {
       menuJuego.SetActive(true);
       menuPausa.SetActive(false);
       menuPrincipal.SetActive(false);
       menuRespawn.SetActive(false);
    }

    public void MostrarPanelPausa()
    {
        menuJuego.SetActive(false);
        menuPausa.SetActive(true);
        menuPrincipal.SetActive(false);
        menuRespawn.SetActive(false);
    }

    public void MostrarPanelGameOver()
    {
        menuJuego.SetActive(true);
        menuPausa.SetActive(false);
        menuPrincipal.SetActive(false);
        menuRespawn.SetActive(false);
    }

    public void MostrarPanelFinalizado()
    {
        menuJuego.SetActive(false);
        menuPausa.SetActive(false);
        menuPrincipal.SetActive(false);
        menuRespawn.SetActive(true);
    }

    public void PanelDesactivados ()
    {
        menuJuego.SetActive(false);
        menuPausa.SetActive(false);
        menuPrincipal.SetActive(false);
        menuRespawn.SetActive(false);
    }
}




