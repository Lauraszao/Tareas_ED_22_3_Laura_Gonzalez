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
