using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomitem : MonoBehaviour
{
    public GameObject[] itemfab;
    public float Enamylivetime = 5f;
    //float i = 1f;
    public float time;
    public Transform positionl;

    //private void Awake()
    //{
    //time = EnemyAiTutorial.Instane.health;
    //}
    
    public void itemtime(int heal)
    {
        time = heal;   
    }
    void Update()
    {
        var go = GameObject.FindGameObjectsWithTag("Item");
        print(go.Length);

        print(time);
        if (go.Length <=10 && time == 0 )
        {
            int randomIndex = Random.Range(0, itemfab.Length);
            Vector3 randomSpawnPosition = positionl.position;
            Instantiate(itemfab[randomIndex], randomSpawnPosition, Quaternion.identity);
            
            

        }





    }
}
