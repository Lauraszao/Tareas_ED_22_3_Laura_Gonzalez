using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    public Color color1;
 void OnMouseDown()
    {
        // Destroy the gameObject after clicking on it
        Destroy(gameObject);
        
    }
}
