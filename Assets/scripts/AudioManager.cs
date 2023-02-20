using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    static public AudioManager instance;//el estatic hace q solo pueda ahber una variable asi en el codigo y el static + el public hace q se pueda llamar desde todo el codigo(singletone)
    //una variable static (estatica) es una variable q solo puede existir una vez por ejecucion de la aplicacion.solo existe una copia en el codigo.y se hace accesible desde cualquier lugar del codigo.

    private List<GameObject> activeAudioGameObjects;  //lista



    private void Awake()
    {
        if (instance)
        {
            Destroy(gameObject);

        }
        else
        {
            instance = this;
            activeAudioGameObjects = new List<GameObject>();
            DontDestroyOnLoad(gameObject);
        }
    }


    public AudioSource PlayAudio(AudioClip clip, float volume = 1)  //es el metodo al q hay q llamar
    {
        GameObject sourceObj = new GameObject(clip.name);   //crea el object en escena con el nombre del clip
        activeAudioGameObjects.Add(sourceObj);  //lo añade a la lista
        sourceObj.transform.SetParent(this.transform);  //crea hijo
        AudioSource source = sourceObj.AddComponent<AudioSource>();  //añade el componente source al objeto q estamos creando
        source.clip = clip;  //el clip
        source.volume = volume;  // la variable del volumen
        //source.pitch = 1.5f;
        source.Play();
        StartCoroutine(PlayAudio(source));
        return source;
    }


    public AudioSource PlayAudioOnLoop(AudioClip clip, float volume = 1)
    {
        GameObject sourceObj = new GameObject(clip.name);
        activeAudioGameObjects.Add(sourceObj);
        sourceObj.transform.SetParent(this.transform);
        AudioSource source = sourceObj.AddComponent<AudioSource>();
        source.clip = clip;
        source.volume = volume;
        source.loop = true;
        source.Play();
        return source;
    }


    public void ClearAudioList()   //limpia la lista para q no sigan sonando sonidos 
    {
        foreach(GameObject go in activeAudioGameObjects)
        {
            Destroy(go);
        }
        activeAudioGameObjects.Clear();
    }

    IEnumerator PlayAudio(AudioSource source)
    {
        while ( source && source.isPlaying)
        {
            yield return null;
        }

        if (source)
        {
            activeAudioGameObjects.Remove(source.gameObject);
        }
    }



}
