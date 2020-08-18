using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement1;
    public PlayerMovement movement2;
    public Switch controls;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Obstacle")
        {
            movement1.enabled = (false);
            movement2.enabled = (false);
            controls.enabled = (false);
            FindObjectOfType<GameManager>().endGame();
        }
    }
}
