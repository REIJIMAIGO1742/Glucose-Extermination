using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enamysricpt : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("PBullet"))
        {            
            Destroy(gameObject);
        }
    }
}
