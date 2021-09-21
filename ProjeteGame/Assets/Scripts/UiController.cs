using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiController : MonoBehaviour
{
    public GameObject Image; 
    public bool trigger;

    private void Update()
    {
        if (trigger == true && Input.GetKeyDown(KeyCode.E)) Image.SetActive(true);
        if (trigger == false) Image.SetActive(false);
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
