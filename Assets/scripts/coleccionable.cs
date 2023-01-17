using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coleccionable : MonoBehaviour
{
    public Vector2 speed;
    //variables crono
    float currentTime;//el tiempo q corre el crono
    public float
        maxTime = 1.5f;//tiempo maximo al q llega el crono

    //declaracion rigibody
    private Rigidbody2D colecionable;
    // Start is called before the first frame update
    void Start()
    {
        colecionable = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //velocidad de la bala
        colecionable.velocity = speed;

        //destruccion bala con crono
        currentTime += Time.deltaTime;
        if (currentTime >= maxTime)
        {
            Destroy(gameObject);
            currentTime = 0;
        }
    }
}
