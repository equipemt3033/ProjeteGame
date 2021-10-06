using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Indestructable : MonoBehaviour

{
    void Start()
    {
        for (int i = 0; i < Object.FindObjectsOfType<Indestructable>().Length; i++)
        {
            if (Object.FindObjectsOfType<Indestructable>()[i] != this)
            {
                if(Object.FindObjectsOfType<Indestructable>()[i].name == gameObject.name)
                {
                    Destroy(gameObject);
                }
            }
        }
        DontDestroyOnLoad(gameObject);
    }
}
