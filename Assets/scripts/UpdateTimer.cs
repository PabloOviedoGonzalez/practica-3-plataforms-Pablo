using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateTimer : MonoBehaviour
{
    public TMPro.TMP_Text timeText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //accedemos al instance del GameManager para acceder tmbn al metodo gettime y le añadimos el Tostring para hacer el numero de solo 3 digitos en pantalla
        timeText.text = "Tiempo: " + GameManager.instance.GetTime().ToString("0.00"); 
    }
}
