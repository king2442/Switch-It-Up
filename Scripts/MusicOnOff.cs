using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicOnOff : MonoBehaviour
{
    public GameObject musicSource;
    public Text music;
    private static int count = 0;
    public static GameObject instance;

    void Update()
    {
        if (count == 0)
        {
            musicSource.SetActive(true);
        }
        else
        {
            musicSource.SetActive(false);
        }
    }
    public void MusicToggle()
    {
        if(count==0)
        {
            count++;
            music.text = "Music:\nOFF";
        }
        else
        {
            count--;
            music.text = "Music:\nON";
        }
    }
}
