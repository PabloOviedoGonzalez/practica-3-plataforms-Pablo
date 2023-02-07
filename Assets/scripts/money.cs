using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class money : MonoBehaviour
{



    private void OnTriggerEnter2D(Collider2D other)//declarar metodo para el destroy
    {
        if (other.GetComponent<PlatformPlayer>())// if para q el otro componente
        {
            Destroy(gameObject.gameObject);
            GameManager.instance.AddPunt(10);
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
