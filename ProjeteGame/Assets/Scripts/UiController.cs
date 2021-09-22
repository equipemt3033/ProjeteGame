using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiController : MonoBehaviour
{
    public GameObject Image;
    public GameObject Monolog;
    public bool trigger;
    private bool imageEnabled = false;

    private void Update()
    {
        if (trigger == true && Input.GetKeyDown(KeyCode.E)) {
            Image.SetActive(true);
            imageEnabled = true;
        }

        if (!trigger)
        {
            Image.SetActive(false);
            if (imageEnabled)
            {
               Monolog.SetActive(true);
               imageEnabled = false;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) trigger = true;      
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player")) trigger = false;
    }
}
