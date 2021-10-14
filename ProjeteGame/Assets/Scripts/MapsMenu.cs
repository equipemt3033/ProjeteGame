using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapsMenu : MonoBehaviour
{
    public static bool MapsOn = false;
    public GameObject Maps;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M)) {

            MapsOn = true;
            if (MapsOn) Maps.SetActive(true);

            else {
                Resume();
            }
        }
    }
    public void Resume()
    {
        Maps.SetActive(false);
        MapsOn = false;
    }
}
