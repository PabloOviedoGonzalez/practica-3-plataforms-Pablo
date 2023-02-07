using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UptadeMoney : MonoBehaviour
{
    public TMPro.TMP_Text moneyText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moneyText.text = "Money: " + GameManager.instance.GetPunt();
    }
}
