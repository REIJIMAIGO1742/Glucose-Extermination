using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercam : MonoBehaviour
{
    public Transform Cameraposition;
    
    // Update is called once per frame
    void Update()
    {
        transform.position = Cameraposition.position;
        
            
            
    }
}
