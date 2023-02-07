using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; //el estatic hace q solo pueda ahber una variable asi en el codigo y el static + el public hace q se pueda llamar desde todo el codigo(singletone)

    public AudioClip nombre;
    [Range(0, 1)]
    public float nombreVolume;

    private int puntuacion = 0;

    private float time = 0;
    // Start is called before the first frame update
    void Awake() // se hace en el awake para q se inicialice lo primero, por si en el start hubiera algo q lo use y lo usase antes de q se iniciase
    {
        if (instance == null)//comprueba si instance no contiene informacion. tambien hace q no se destruya nunca
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            //si tiene info, significa q ya existe otro GameManager y destruye este para q no se duplique ya q solo puede haber uno
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        time += Time.deltaTime;

        //if(time > 5 )
        //{
        //    AudioManager.instance.PlayAudio(nombre, nombreVolume);
        //}
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

    public void ChangeScene(string name)
    {
        time = 0;
        puntuacion = 0;
        SceneManager.LoadScene(name);
        //AudioManager.instance.ClearAudioList();
    }
  
}
