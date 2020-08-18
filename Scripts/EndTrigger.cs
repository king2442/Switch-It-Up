using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    private int count = 0;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            count++;
            if (count == 2)
            {
                gameManager.levelComplete();
            }
            if (count == 1)
            {
                gameManager.endGame();
            }
        }

    }
}
