using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    [System.Serializable]
    public class Sound
    {
        public string name;
        public AudioClip clip;

        [Range(0f, 1f)]
        public float volume;

        [HideInInspector]
        public AudioSource source;
    }

    public Sound[] sounds;

    void Awake()
    {
        for (int i = 0; i < sounds.Length; i++)
        {
            Sound s = sounds[i];
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
        }
    }
    public void Play( string name )
    {
        for (int i = 0; i < sounds.Length; i++)
        {
            Sound s;
            if (name == sounds[i].name)
            {
                s = sounds[i];
                s.source.Play();
                break;
            }
        }
    }
    public void Pause( string name )
    {
        for (int i = 0; i < sounds.Length; i++)
        {
            Sound s;
            if (name == sounds[i].name)
            {
                s = sounds[i];
                s.source.Pause();
                break;
            }
        }
    }
}
