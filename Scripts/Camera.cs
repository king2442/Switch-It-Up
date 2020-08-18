using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform player1;
    public Transform player2;
    public Vector3 offset1, offset2;

    
    // Update is called once per frame
    void Update()
    {
        if (player1.gameObject.activeSelf && player2.gameObject.activeSelf)
            transform.position = player1.position + offset1;

        else if (player1.gameObject.activeSelf)
            transform.position = player1.position + offset1;

        else
            transform.position = player2.position + offset2;
    }
}
