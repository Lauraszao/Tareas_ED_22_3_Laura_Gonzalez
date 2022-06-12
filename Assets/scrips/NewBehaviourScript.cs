using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    public TextMeshProUGUI texto;
    // Start is called before the first frame update
    void Start()
    {
        texto.text= "¿Qué película quieres ver ?";
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.A))
       {
         texto.text ="Coraline y la puerta secreta";
       } 
       if(Input.GetKeyDown(KeyCode.B))
       {
         texto.text ="El cadaver de la novia";
       } 
       if(Input.GetKeyDown(KeyCode.C))
       {
         texto.text ="El extraño mundo de Jack";
       } 
       if(Input.GetKeyDown(KeyCode.D))
       {
         texto.text ="Lo que el agua se llevó";
       }   
    }
}
