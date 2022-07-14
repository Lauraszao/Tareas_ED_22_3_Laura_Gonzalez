using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2 : MonoBehaviour
{
 
    Rigidbody m_Rigidbody;
    public float m_Thrust = 20f;
    public float velocidad = 0.5f;
    public float fuerzaSalto;
    private Rigidbody2D rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        transform.position = new Vector3(-7.44f,4.14f,0f);
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKey(KeyCode.A))
      {
        transform.position += Vector3.left * velocidad * Time.deltaTime;
      } 
      if(Input.GetKey(KeyCode.D))
      {
        transform.position += Vector3.right * velocidad * Time.deltaTime;
      } 
      ProcesarSalto();
    }

    void ProcesarSalto()
    {
      if(Input.GetKeyDown(KeyCode.W))
      {
        rigidBody.AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);
      }
    }
    

}
