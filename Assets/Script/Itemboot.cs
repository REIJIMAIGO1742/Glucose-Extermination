using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Itemboot : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerMovementTutorial bootjump;
    public int itemvalue;
    // Start is called before the first frame update


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            bootjump.superjump(itemvalue);
            Destroy(gameObject);
        }

    }
}
