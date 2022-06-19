using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    
    
 void OnMouseDown()
    {
        // Destroy the gameObject after clicking on it
        Destroy(gameObject);
        
    }
}
