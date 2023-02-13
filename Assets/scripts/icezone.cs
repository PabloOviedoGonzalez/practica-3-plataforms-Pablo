using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class icezone : MonoBehaviour
{
    public AudioClip slipSound;
    AudioSource Aux;              //creamos una variable auxiliar para guardar la info y poder llamarla en otra parte del scrip y tener mas control sobre ella
    [Range(0, 1)]
    public float slipVolume;


    private void OnTriggerEnter2D(Collider2D other)   // creamos el ontrigger 
    {
          Rigidbody2D rb;
        
        if (other.GetComponent<PlatformPlayer>())   //le decimos q tiene q ser cuando sea el PlatformPlayer
        {
            other.GetComponent<PlatformPlayer>().slide = 5;
            Aux = AudioManager.instance.PlayAudioOnLoop(slipSound, slipVolume);  //metemos la info del audio manager en la variable aux
        }


    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Rigidbody2D rb;

        if (other.GetComponent<PlatformPlayer>())
        {
            other.GetComponent<PlatformPlayer>().slide = 0;
            Destroy(Aux.gameObject);   //destruimos la variable aux para q la musica para cuando salgamos de la zona
        }


    }

   
}
