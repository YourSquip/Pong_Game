using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuOptions : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        Exit();
    }

    void Exit()
    {
        if(Input.GetKeyDown(KeyCode.Q)) { 
            Application.Quit();
        }
    }
}
