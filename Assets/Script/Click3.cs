using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click3 : MonoBehaviour
{
    public string mensaje;
public Color color1;
 
void OnMouseDown()
{
   Debug.Log(mensaje);
    Destroy(gameObject);
   
    
   }
   

}  

