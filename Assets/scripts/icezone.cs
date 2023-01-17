using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class icezone : MonoBehaviour
{
   
    
    private void OnTriggerEnter2D(Collider2D other)
    {
          Rigidbody2D rb;
        
        if (other.GetComponent<PlatformPlayer>())
        {
            other.GetComponent<PlatformPlayer>().slide = 5;
        }


    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Rigidbody2D rb;

        if (other.GetComponent<PlatformPlayer>())
        {
            other.GetComponent<PlatformPlayer>().slide = 0;
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
