using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiController : MonoBehaviour
{
    [SerializeField] private GameObject Image;
    [SerializeField] private GameObject Monolog;
    public bool trigger;
    private bool imageEnabled = false;

    private void Update()
    {
        if (Image != null)
        {
            if (trigger == true && Input.GetKeyDown(KeyCode.E))
            {
                Image.SetActive(true);
                imageEnabled = true;
            }

            if (!trigger)
            {
                Image.SetActive(false);

                if (imageEnabled)
                {
                    imageEnabled = false;
                    GetComponent<Collider2D>().enabled = false;

                    if (Monolog != null) Monolog.SetActive(true);

                    else return;
                }
            }
        }
        else return;
        
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
