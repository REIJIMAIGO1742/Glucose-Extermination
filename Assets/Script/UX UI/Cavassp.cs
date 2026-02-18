using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Cavassp : MonoBehaviour
{

    public Canvas canvas;
    bool esctime;
    // Start is called before the first frame update
    void Start()
    {
        canvas.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (esctime)
            {
                Resumegame();
            }
            else
            {
                Pausegame();
            
            }
            

            
        }

        
    }

    public void Resumegame()
    {
        canvas.gameObject.SetActive(false);

        Time.timeScale = 1;
        print("in");
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        esctime = false;
    }

    public void Pausegame()
    {
        canvas.gameObject.SetActive(true);

        Time.timeScale = 0;
        print("in");
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        esctime = true;

    }
}
