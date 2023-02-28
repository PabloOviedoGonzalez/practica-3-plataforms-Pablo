using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateEnemys : MonoBehaviour
{

    public TMPro.TMP_Text enemysText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemysText.text = "enemys: " + GameManager.instance.GetEnemysDeath();
    }
}
