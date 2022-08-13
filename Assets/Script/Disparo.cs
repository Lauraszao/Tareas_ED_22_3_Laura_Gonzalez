//Nombre del desarrollador: Laura Gonzalez Sandoval
//Asignatura: Estructura de datos
//Profesor: Josué Israel Rivas Diaz
//Fuente en la que base el script: De las clases del profesor Josué Rivas 
//Descripción: Este script me va a servir para que el enemigo lanze kunai, y cada cierto tiempo estos desaparecerán
//el objeto que saldrá es el kunai, el cual va a salir de la mano
//También se le asigna una pdirección hacia la cual va ser lanzado el kunai
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour

{// Esta variable aparecerá  en el inspector  para que le asigne un gameobject
    public GameObject kunai;
    //esta variable sirve para asiganrle el punto de donde saldrá el Kunai
    public Transform mano;
    // Start is called before the first frame update
    void Start()
    {//respawnea el objeto cada cierto tiempo
        InvokeRepeating("Spawn",0,1);
    }
    //Instantaneamente la bala sale de la mano en dirección hacia lado contrario 
    void Spawn(){
       Instantiate(kunai,mano.position,Quaternion.identity);
    }
}
