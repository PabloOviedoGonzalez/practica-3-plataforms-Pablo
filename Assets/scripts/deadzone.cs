using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deadzone : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)//declarar metodo para el destroy
    {
        if (other.collider.GetComponent<PlatformPlayer>() || other.collider.GetComponent<enemigo>())// if para q el otro componente
        {
            Destroy(other.gameObject);
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
