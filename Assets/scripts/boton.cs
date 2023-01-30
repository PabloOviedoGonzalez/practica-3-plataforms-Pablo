using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class boton : MonoBehaviour
{
   public void ChangeScene(string name)
    {
        // SceneManager.LoadScene(name);
        GameManager.instance.AddPunt(20);
        
    }
}
