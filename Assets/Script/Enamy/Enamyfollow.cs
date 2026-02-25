using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enamyfollow : MonoBehaviour
{

    public NavMeshAgent Enamy;

    public Transform Player;

    // Update is called once per frame
    void Update()
    {
        Enamy.SetDestination(Player.position);
        

    }
}
