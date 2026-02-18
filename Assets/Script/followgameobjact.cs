using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followgameobjact : MonoBehaviour
{
    public Transform paren;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = paren.position;
    }
}
