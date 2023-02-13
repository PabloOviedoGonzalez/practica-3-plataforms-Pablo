using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class money : MonoBehaviour
{
    public AudioClip monySound;
    [Range(0, 1)]
    public float monyVolume;


    private void OnTriggerEnter2D(Collider2D other)//declarar metodo para el destroy
    {
        if (other.GetComponent<PlatformPlayer>())// if para q el otro componente
        {
            Destroy(gameObject.gameObject);
            GameManager.instance.AddPunt(10);
            AudioManager.instance.PlayAudio(monySound, monyVolume);
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
