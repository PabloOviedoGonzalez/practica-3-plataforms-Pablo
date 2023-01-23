using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public float speed;
    public float posi = 1f;
    public Transform transposi;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 posicam4 = new Vector3(transposi.position.x + posi, -0, 5f - 10f);
        transform.position = Vector3.Slerp(transform.position, posicam4, speed * Time.deltaTime);
    }
}
