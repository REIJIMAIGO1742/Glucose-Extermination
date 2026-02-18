using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enamy"))
        {
            print("hit" + collision.gameObject.name + (" !"));
            Destroy(gameObject);
        }
    }

}
