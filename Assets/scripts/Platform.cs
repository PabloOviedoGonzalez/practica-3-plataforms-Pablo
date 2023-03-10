using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    private Rigidbody2D rb;
    float currentTime;
    public float 
        maxTime = 2, 
        speed = 20;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        currentTime += Time.deltaTime;
        if (currentTime >= maxTime)
        {
            speed = -speed;
            currentTime = 0;
        }
    }
}
