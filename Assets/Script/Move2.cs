using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2 : MonoBehaviour
{// se crea una varible publica de tipo rigidbody2d
   public Rigidbody2D  rb; 
// se crea una variable publica float para poder cambiar la velocidad en unity 
   public float speed;
    //varible publica float con una fuerza de salto de 5
    public float jumpForce = 5;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {// se coloca condicionante, si presiono la tecla w mi personaje salta
        if(Input.GetKeyUp(KeyCode.W)){
            rb.AddForce(Vector3.up*jumpForce,ForceMode2D.Impulse);
        }

       // se coloca condicionante, si presiono la tecla D mi personaje se mueve a la derecha
       if (Input.GetKey(KeyCode.D))
       {// se usan dos vectores x y y , en la cual la velocidad y el rb se le asigna a la direccion y o sea  ala derecha
           rb.velocity = new Vector2(speed,rb.velocity.y);
       }
        // se coloca condicionante , si presiono la letra A mi personaje de mueve a la izquiersa
          if (Input.GetKey(KeyCode.A))
       {  //rb por la velocidad es igual a vector dos , donde la celocidad es negativa es decir, va en direccion izquiersa usando dos vecores
       
           rb.velocity = new Vector2(-speed,rb.velocity.y);
       }
     
    }
}