using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubetrigger : MonoBehaviour
{

    //declaramos 
    public GameObject colecionable;
    public GameObject desdeaqui;
    public float speed = 15;

    public AudioClip jumpSound;
    [Range(0, 1)]
    public float jumpVolume;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<PlatformPlayer>())
        {
            GameObject clone1 = Instantiate(colecionable,desdeaqui.transform.position, Quaternion.identity);
            clone1.GetComponent<coleccionable>().speed = new Vector2(0, speed);
            GameManager.instance.AddPunt(10);
            AudioManager.instance.PlayAudio(jumpSound, jumpVolume);
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
