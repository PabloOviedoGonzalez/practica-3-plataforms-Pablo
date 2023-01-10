using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigo : MonoBehaviour
{
    // declarar variables
    private const string Tag = "Player";
    public Transform ObjectToFollow = null;
    public float Speed = 2;
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

        transform.position = Vector2.MoveTowards(transform.position, ObjectToFollow.transform.position, Speed * Time.deltaTime);
        transform.up = ObjectToFollow.position - transform.position;
    }
}
