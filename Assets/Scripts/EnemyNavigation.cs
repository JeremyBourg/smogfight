using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyNavigation : MonoBehaviour
{

    private NavMeshAgent agent;
    [SerializeField]
    private Transform player;
    private Vector3 initialPosition;

    public GameEvent smokeCollisionEvent;
    // Start is called before the first frame update
    void Start()
    {
        agent = gameObject.GetComponent<NavMeshAgent>();
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(initialPosition, player.transform.position) < 25.0f){
            agent.SetDestination(player.position);

            Vector3 direction = player.position - transform.position;
            Quaternion targetRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 2.0f);
        }
        else{
            agent.SetDestination(initialPosition);
        }
    }
}
