using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movecam : MonoBehaviour
{
    public Slider slider;

    public float sensx;
    public float sensy;

    public Transform oriantation;
    public Transform Gunor;

    //public float mouseSensitivity = 100f;


    float xRotation;
    float yRotation;
    //Start is called before the first frame update
    void Start()
    {
        
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        float mousex = Input.GetAxisRaw("Mouse X") * GameSettings.Mosuesensitivity * Time.deltaTime * 100f;
        float mousey = Input.GetAxisRaw("Mouse Y") * GameSettings.Mosuesensitivity * Time.deltaTime * 100f;

        yRotation += mousex;

        xRotation -= mousey;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        //yRotation = Mathf.Clamp(90f, yRotation, -90f);


        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        oriantation.rotation = Quaternion.Euler(0, yRotation, 0);
        Gunor.rotation = Quaternion.Euler(xRotation, yRotation, 0);

    }

 
        
}
