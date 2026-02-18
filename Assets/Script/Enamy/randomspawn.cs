using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomspawn : MonoBehaviour
{
    public GameObject[] enamyfab;
    public float Enamylivetime = 5f;
    float i = 1f;


    void Update()
    {
        var go = GameObject.FindGameObjectsWithTag("Enamy");
        print(go.Length);

        
        if (go.Length == 100)
        {
            print("finish!");
            //Enamylivetime = 0f;

        }

        else
        {
            int randomIndex = Random.Range(0, enamyfab.Length);
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-110, 200), 0, Random.Range(-110, 200));
            Instantiate(enamyfab[randomIndex], randomSpawnPosition, Quaternion.identity);
            Enamylivetime = i++;

        }

        


    }
}