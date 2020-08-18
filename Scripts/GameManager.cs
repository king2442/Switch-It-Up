using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameOver = false;
    public GameObject levelcompleteText;
    public GameObject gameoverText;
    public AudioManager audioManager;

    public void levelComplete()
    {
        audioManager.Pause("Obstacle");
        if (gameoverText.activeSelf)
            gameoverText.SetActive(false);
        audioManager.Play("Complete");
        levelcompleteText.SetActive(true); 
    }

    public void endGame()
    {
        if (gameOver == false)
        {
            audioManager.Play("Obstacle");
            gameOver = true;
            gameoverText.SetActive(true);
            Invoke("restart", 2f);
        }
    }
    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
