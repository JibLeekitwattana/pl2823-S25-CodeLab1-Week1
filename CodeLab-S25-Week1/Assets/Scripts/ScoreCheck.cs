using System;
using UnityEngine;

public class ScoreCheck : MonoBehaviour
{
    public GameObject eyes;
    void Start()
    {
        
    }
    
    void Update()
    {
      
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("paw"))
        {
            Debug.Log("hit!");
            eyes.SetActive(true);
        }

        if (other.gameObject.CompareTag("startBread"))
        {
            eyes.SetActive(false);
            Debug.Log("turn off");
        }
    }
}
