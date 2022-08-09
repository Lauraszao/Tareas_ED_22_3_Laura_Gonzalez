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
        //si score recolecta mas o igual a 5 monedas
        if(score >=23){
            // se manda un mensaje de ganaste 
            Debug.Log("Ganaste!");
        }
    }
 
private void OnCollisionEnter2D(Collision2D other) 
{
    if (other.gameObject.tag=="Monedas")
    {   score ++;
        Destroy(other.gameObject);
        Debug.Log("score:"+ score);
    }
}
}  

