using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbientMusic : MonoBehaviour
{
    public AudioClip ambientMusic;
    [Range(0, 1)]
    public float volumeMusic;

    // Start is called before the first frame update
    void Start()
    {
        AudioManager.instance.PlayAudioOnLoop(ambientMusic, volumeMusic);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
