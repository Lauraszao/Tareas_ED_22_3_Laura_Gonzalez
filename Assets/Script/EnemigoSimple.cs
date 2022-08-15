//Nombre del desarrollador: Laura Gonzalez Sandoval
//Asignatura: Estructura de datos
//Profesor: Josué Israel Rivas Diaz
//Fuente en la que base el script: De las clases del profesor Josué Rivas 
//Descripción general:Se le asigna un traslado al enemigo , para que este se desplace en dirección al jugador a la izquierda
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoSimple : MonoBehaviour
{//Variable publica de tipo speed 
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {//Se le asigna un traslado al enemigo , para que este se desplace en dirección al jugador a la izquierda
        transform.Translate(Vector3.left*speed*Time.deltaTime);
    }
}
