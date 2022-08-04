using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Colision : MonoBehaviour
{//variable publica tipo numerica
    public int score;
    //variable de tipo textmeshprougui para que este se refleje en la pantalla del jugador 
    public TextMeshProUGUI scoreText;
//
    private void Start() {
        //va actualizando y va sumndo las monedas recolectadas
        scoreText.text = "Score actual: " + score;
    }

    private void Update() {
        //si score recolecta mas o igual a 5 monedas
        if(score >= 5){
            // se manda un mensaje de ganaste 
            Debug.Log("Ganaste!");
        }
    }
    
//cuando la colision entre o se de en contacto el evento se lleva a cabo, al primer contacto 
private void OnCollisionEnter2D(Collision2D other) {
    
//cualquier objeto que tenga un colisionador 2d alrededor del sistema y genera un impacto, 
//a cambio se devuelve un mensaje en pantalla 
    if (other.gameObject.name=="Pared")
    {//mandar un mensaje 
        Debug.Log("Cuidado!");
    }
    //parametro other que lee un objeto que tiene una etiqueta que es igual a pared
    
    if (other.gameObject.tag=="moneda")
    {
        //cada vez que toma las monedas este suma 1 
        score++;
        scoreText.text = "Score actual: " + score;
        //Cuando choca con el objeto este se destruye
        Destroy(other.gameObject);
        // y manda un score de los puntos que lleva registrados 
        Debug.Log("Score actual: " + score);
    }
    
}
//Mientras esté dentro de la colision el evento se está ejecutando, mientras se esté en contacto 
//se efectua un daño etc. mientras el contacto continue
void OnCollisionStay2D(Collision2D other){
  
}

private void OnCollisionExit2D(Collision2D other) {
    
}

}
