using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cabeza : MonoBehaviour
{

    public AudioClip hitSound;
    [Range(0, 1)]
    public float hitVolume;


    private void OnTriggerEnter2D(Collider2D other)//declarar metodo para el destroy
    {
        if (other.GetComponent<PlatformPlayer>())// if para q el otro componente
        {
            Destroy(gameObject.transform.parent.gameObject);
            GameManager.instance.AddPunt(10);
            AudioManager.instance.PlayAudio(hitSound, hitVolume);
            GameManager.instance.AddPuntEnemys(1);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
