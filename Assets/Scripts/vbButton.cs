using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;//Escencial para el uso de Vuforia

public class vbButton : MonoBehaviour, IVirtualButtonEventHandler //Para usar el botón virtual se debe poner al inicio del script
{
    public GameObject vbBtnObj;
    public Animator cubeAni;
 // En el start vamos a realizar los llamados para la animación del cubo
 //También vamos a buscar el GameObject llamado "Botón" ESTO IMPORTANTE TENER EN CUENTA YA QUE SI PONES OTRO NOMBRE SIMPLEMENTE NO PODRÁS INTERACTUAR
 //También al botón virtual le llamamos el componente de boton virtual y que registre el evento
void Start () 
    {
        vbBtnObj = GameObject.Find("Boton");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        cubeAni.GetComponent<Animator>();
    } 
 //Con el onButtonPressed y llamando al botón virtual vamos a hacer que el cubo se anime
 // O sea al "tocar" el botón dicho cubo empezará a rotar
public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        cubeAni.Play("Cube");
    }
//Aqui al dejar de tocar el boton el cubo simplemente se detendrá
public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        cubeAni.Play("none");
    }
}