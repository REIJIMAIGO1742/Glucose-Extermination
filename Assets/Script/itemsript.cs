using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class itemsript : MonoBehaviour
{
    public PlayerMovementTutorial GetH;
    public int itemvalue;
    // Start is called before the first frame update
    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GetH.heal(itemvalue);
            Destroy(gameObject);
        }
        
    }


}
