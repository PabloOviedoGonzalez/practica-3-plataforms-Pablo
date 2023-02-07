using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deadzone : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)//declarar metodo para el destroy
    {
        if (other.collider.GetComponent<PlatformPlayer>())// if para q el otro componente
        {
            GameManager.instance.ChangeScene("GameOver");
        }
    }
    
}
