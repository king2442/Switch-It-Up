using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsCount : MonoBehaviour
{
    public GameObject Sphere1;
    public GameObject Sphere2;
    public Text points;
    private int count;
    public AudioManager audioManager;

    void Start()
    {
        count = 0;
        SetPointValue();
    }
    void OnTriggerEnter(Collider other)
    {
        int.TryParse(points.text, out count);  //so that value of "points" is not lost when one of the gameObjects become inactive
        if (other.gameObject.tag == "Collectible")
        {
            audioManager.Play("Collectible");
            other.gameObject.SetActive(false);
            count++;
            SetPointValue();
        }
    }
    void SetPointValue()
    {
        points.text = count.ToString();
    }
}
