using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    // FixedUpdate is called once per physics frame
    void FixedUpdate()
    {
         float moveHorizontal = Input.GetAxis("Horizontal");
         float moveVertical = Input.GetAxis("Vertical");
         Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

         rb.AddForce(movement * speed, ForceMode.VelocityChange);
        if (rb.position.y < -0.5f)
            FindObjectOfType<GameManager>().endGame();
        if (Input.GetKey(KeyCode.R))
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
