using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Indestructable : MonoBehaviour
{
    public string objectID;

    private void Awake()
    {
        objectID = name + transform.position.ToString() + transform.eulerAngles.ToString();
    }
    void Start()
    {
        for (int i = 0; i < Object.FindObjectsOfType<Indestructable>().Length; i++)
        {
            if(Object.FindObjectsOfType<Indestructable>()[i] != this)
            {
                if(Object.FindObjectsOfType<Indestructable>()[i].objectID == objectID)
                {
                    Destroy(gameObject);
                }
            }
        }
        DontDestroyOnLoad(gameObject);
    }
    

}
