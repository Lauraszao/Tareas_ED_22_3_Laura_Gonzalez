using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Datos : MonoBehaviour
{
    public string Nombre;
    public string tipo;
    public string precio;
    public string efecto;
    public string[] datos;
    // Start is called before the first frame update
    void OnEnable ()
    {
        datos= new string[]{Nombre, tipo, precio, efecto};
      
    }
    public string GetDatos(int indice)
    {
        return datos[indice];
    }
   
}