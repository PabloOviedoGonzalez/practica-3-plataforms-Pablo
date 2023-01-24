using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colecionable : MonoBehaviour
{
    public Vector2 speed;
    float currentTime;//el tiempo q corre el crono
    public float
        maxTime = 1.5f;//tiempo maximo al q llega el crono
    private Rigidbody2D coleccionable1;
    // Start is called before the first frame update
    void Start()
    {
        coleccionable1 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //velocidad de la bala
        coleccionable1.velocity = speed;
        //destruccion bala con crono
        currentTime += Time.deltaTime;
        if (currentTime >= maxTime)
        {
            Destroy(gameObject);
            currentTime = 0;
        }
    }
}
