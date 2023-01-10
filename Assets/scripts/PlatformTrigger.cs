using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlatformPlayer p = collision.GetComponent<PlatformPlayer>();
        if(p)
        {
            p.gameObject.transform.parent = transform.parent;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        PlatformPlayer p = collision.GetComponent<PlatformPlayer>();
        if (p)
        {
            p.gameObject.transform.parent = null;
        }







        //GameObject clone1 = Instantiate(gameObject);
        //clone1.GetComponent<Bullet>().speed = new Vector2(0, 10);


        //GameObject clone2 = Instantiate(gameObject);
        //clone2.GetComponent<Bullet>().speed = new Vector2(0, -10);


        //GameObject clone3 = Instantiate(gameObject);
        //clone3.GetComponent<Bullet>().speed = new Vector2(10, 0);

    }
}
