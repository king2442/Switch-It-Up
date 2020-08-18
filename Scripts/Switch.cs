using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    private int Test = 0;
    public GameObject[] objects;
    private Rigidbody rb0;
    private Rigidbody rb1;
    public AudioManager audioManager;

    void Start()
    {
        rb0 = objects[0].GetComponent<Rigidbody>();
        rb1 = objects[1].GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            audioManager.Play("Switch");
            Test++;
            if (Test % 2 != 0)
            {
                objects[1].transform.position = objects[0].transform.position + new Vector3(3.0f,0f,0f);
                objects[0].SetActive(false);
                objects[1].SetActive(true);
            }
            else
            {
                objects[0].transform.position = objects[1].transform.position + new Vector3(-3.0f, 0f, 0f);
                objects[1].SetActive(false);
                objects[0].SetActive(true);
            }
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            audioManager.Play("Switch");
            if (objects[0].gameObject.activeSelf)
            {
                objects[1].SetActive(true);
                objects[1].transform.position = objects[0].transform.position + new Vector3(3.0f, 0f, 0f);
                rb1.velocity = rb0.velocity;
            }
            else if(objects[1].gameObject.activeSelf)
            { 
                objects[0].SetActive(true);
                objects[0].transform.position = objects[1].transform.position + new Vector3(-3.0f, 0f, 0f);
                rb0.velocity = rb1.velocity;
            }
        }
    }
}
