using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BacktoStart : MonoBehaviour
{
    public void GoBack()
    {
        SceneManager.LoadScene(0);
    }
    public void FinalLevel()
    {
        SceneManager.LoadScene(8);
    }
}
