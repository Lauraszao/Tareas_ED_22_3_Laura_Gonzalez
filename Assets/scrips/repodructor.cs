using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class repodructor : MonoBehaviour
{
    [SerializField]
    AudioSource audioS;
    public AudioClip[] ListaAudio;
    public int indice = 0;
    // Start is called before the first frame update
    void Start()
    {
       audioS = GetComponent<AudioSource>();
       //ListaAudio= new AudioClip[3];

       audioS.AudioClip = ListaAudio[indice];
    }

    // Update is called once per frame
    void Update()
    {
        if(input.GetkeyDown(Keycode.Space))
        {
         indice++;
        
        }
        if(input.Getkeylength(Keycode.Space))
        {
           audioS.clip = ListaAudio[3];
        }
        
    }
    
    
}
