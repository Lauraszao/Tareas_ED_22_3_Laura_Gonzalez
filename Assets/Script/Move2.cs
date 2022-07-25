using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2 : MonoBehaviour
{
 
  
    private Rigidbody2D rb;

 
    //Mueve este GameObject 2 unidades por segundo en la dirección de avance
     private float speed = 2f;

    //Se le asign una fuerza de salto
    public float jumpForce = 10;
    // Start is called before the first frame update
    void Start()
    {
      rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
     //Se le asigna la tecla Space
      if(Input.GetKeyUp(KeyCode.Space))
      {
        //Tiene una fuerza e impulso de salto
       rb.AddForce(Vector3.up*jumpForce,ForceMode2D.Impulse);
      }//Se le asigna velocidad en dirección a y
      rb.velocity=new Vector2(5f,rb.velocity.y);

       transform.Translate(Vector3.forward * Time.deltaTime * speed);
       { 
        speed = speed * -1; 
    } 
      
    }

    

}
