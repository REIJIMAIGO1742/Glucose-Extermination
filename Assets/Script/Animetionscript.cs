using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animetionscript : MonoBehaviour
{

    public Transform target;
    Animator am;
    
    // Start is called before the first frame update
    void Start()
    {
        am = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        
        
            
            
        
        
        
            
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            am.SetBool("Walk", false);
        }else
        {
            am.SetBool("Walk", true);
        }
    }
}
