using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class bottonfuncions : MonoBehaviour
{
    public void ChangeScene(string name)
    {
        GameManager.instance.ChangeScene(name);
        //AudioManager.instance.ClearAudioList();
    }
}
