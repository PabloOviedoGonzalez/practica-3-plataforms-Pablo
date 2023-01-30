using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private int puntuacion = 0;

    private float time = 0;
    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)//comprueba si instance no contiene informacion.
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            //si tiene info, significa q ya existe otro GameManager
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        time += Time.deltaTime;
    }

    public void AddPunt(int value)
    {
        puntuacion += value;
    }

    public int GetPunt()
    {
        return puntuacion;
    }

    public float GetTime()
    {
        return time;
    }
  
}
