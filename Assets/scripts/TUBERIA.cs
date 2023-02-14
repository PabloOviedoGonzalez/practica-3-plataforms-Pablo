using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TUBERIA : MonoBehaviour
{

    bool keyPressed = false;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            keyPressed = true;
        }
        else
        {
            keyPressed = false;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.GetComponent<PlatformPlayer>() && keyPressed)
        {
            collision.GetComponent<Animator>().Play("tube");
        }
    }
}
