using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arbolfinish : MonoBehaviour
{

    public AudioClip deadSound;
    [Range(0, 1)]
    public float deadVolume;



    private void OnCollisionEnter2D(Collision2D other)//declarar metodo para el destroy
    {
        if (other.collider.GetComponent<PlatformPlayer>())// if para q el otro componente
        {
            AudioManager.instance.PlayAudio(deadSound, deadVolume);
            Invoke("change", 2);
        }
    }

    void change()
    {
      
             GameManager.instance.ChangeScene("Menu");

    }

}
