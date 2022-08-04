using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2 : MonoBehaviour
{
   public Rigidbody2D  rb; 

   public float speed;
    
    public float jumpForce = 5;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.W)){
            rb.AddForce(Vector3.up*jumpForce,ForceMode2D.Impulse);
        }


       if (Input.GetKey(KeyCode.D))
       {
           rb.velocity = new Vector2(speed,rb.velocity.y);
       }

          if (Input.GetKey(KeyCode.A))
       {
           rb.velocity = new Vector2(-speed,rb.velocity.y);
       }
     
    }
}