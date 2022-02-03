using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitApplication : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            Debug.Log("You have Quit the application.");
            Application.Quit();
        }
    }
}
