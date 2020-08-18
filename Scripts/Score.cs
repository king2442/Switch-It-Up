using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player1;
    public Transform player2;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        if (player1.gameObject.activeSelf)
            scoreText.text = player1.position.z.ToString("0");
        else
            scoreText.text = player2.position.z.ToString("0");
    }
}
