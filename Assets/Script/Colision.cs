//Nombre del desarrollador: Laura Gonzalez Sandoval
//Asignatura: Estructura de datos
//Profesor: Josué Israel Rivas Diaz
//Fuente en la que base el script: De las clases del profesor Josué Rivas 
//Descripción general: Aquí le asignamos un collision a las monedas, para que cuando mi jugador las toque, estas desaparezcan
//y al mismo tiempo estas acumulen puntos, los cuales se verán reflejados en la pantalla de juego
//cuando el jugador recolecte todas las monedas incluyendo la moneda madre, este ganará el juego y arrojara un mensaje de "Ganaste"
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Colision : MonoBehaviour
{ public int score;
    //variable de tipo textmeshprougui para que este se refleje en la pantalla del jugador 
    public TextMeshProUGUI scoreText;
//
    private void Start() {
        //va actualizando y va sumndo las monedas recolectadas
        scoreText.text = "score: " + score;
    }

    private void Update() {
        //si score recolecta mas o igual a 30 monedas
        if(score >=35){
            // se manda un mensaje de ganaste 
            Debug.Log("Ganaste!");
        }
        if(score ==34)
        {
            Debug.Log("¡Perdiste,vuelve a intentarlo!");
        }
    }
 //Se le asigna un private  void , y un collisionenter2d 
private void OnCollisionEnter2D(Collision2D other) 
{// se le asigna condicionante para que mi jugador cuando toque las monedas, este las recolecte 
    if (other.gameObject.tag=="Monedas")
    //va sumando el score 1 en 1 
    {   score ++;
    //cuando mi jugador toca las monedas estas se destruyen 
        Destroy(other.gameObject);
        //aquí se le asigna un comentario el cual aparece en pantalla del juego, arrojando el puntaje 
        Debug.Log("score:"+ score);

    }
    if (other.gameObject.tag=="enemigo2")
    {
        Destroy(other.gameObject);
        Debug.Log("¡Destruido!");
    }
    if (other.gameObject.tag=="enemigo")
    {
        Debug.Log("¡Eso dolió pero no ganarás!");
    }
    if (other.gameObject.tag=="kunai")
    {
        Destroy(other.gameObject);
    }
 }
  void OnCollisionStay2D(Collision2D other)
  {
    if (other.gameObject.tag=="Obstaculos")
    {
      
        Debug.Log("Oucht!");

    }
  }
 }





