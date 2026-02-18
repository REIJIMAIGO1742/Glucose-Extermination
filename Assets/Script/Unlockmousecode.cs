using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlockmousecode : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Unlockmouse();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Unlockmouse()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

}
