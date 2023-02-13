using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigo : MonoBehaviour
{
    // declarar variables
    private const string Tag = "Player";
    public Transform ObjectToFollow = null;
    public float Speed = 2;

    public AudioClip deadSound;
    [Range(0, 1)]
    public float deadVolume;

    private void OnCollisionEnter2D(Collision2D other)//declarar metodo para el destroy
    {
        if (other.collider.GetComponent<PlatformPlayer>())// if para q el otro componente
        {
            Destroy(other.gameObject);
            AudioManager.instance.PlayAudio(deadSound, deadVolume);
            Invoke("change" , 2);
        }
    }


    void change()
    {
        GameManager.instance.ChangeScene("GameOver");

    }

    // Start is called before the first frame update
    void Start()
    {
        ObjectToFollow = GameObject.FindGameObjectWithTag(Tag).GetComponent<Transform>();// invocoar " Player" 
    }

    // Update is called once per frame
    void Update()
    {
        if (ObjectToFollow == null) //por si no hubiese ningun "Player"
            return;

        transform.position = Vector2.MoveTowards(transform.position, new Vector2(ObjectToFollow.transform.position.x, transform.position.y), Speed * Time.deltaTime);
       // transform.up = ObjectToFollow.position - transform.position;
    }
}
