using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2 : MonoBehaviour
{
 
  
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
      rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKeyUp(KeyCode.Space))
      {
       rb.AddForce(Vector3.right*5,ForceMode2D.Impulse);
      }
      rb.velocity=new Vector2(0.5f,rb.velocity.y);
      
    }

    

}
