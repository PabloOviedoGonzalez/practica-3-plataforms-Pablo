using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deadzone : MonoBehaviour
{

    public AudioClip deadSound;
    [Range(0, 1)]
    public float deadVolume;


    private void OnCollisionEnter2D(Collision2D other)//declarar metodo para el destroy
    {
        if (other.collider.GetComponent<PlatformPlayer>())// if para q el otro componente
        {
            AudioManager.instance.PlayAudio(deadSound, deadVolume);   //instanciamos el metodo del AudioManager.
            Invoke("change", 2); //invocamos el metodo para q se active en 2 segundos
        }
    }

    void change()
    {
            GameManager.instance.ChangeScene("GameOver");  //cambiamos de escena al game over

    }
    
}
