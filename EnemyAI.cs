using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;


public class EnemyAI : MonoBehaviour
{
    public enum State
    {
        Idle, Attack
    }
    public State state;

    public Transform spawnPoint;
    public Respawn respawn;
    public GameObject player; // declaring our player object
    Vector3 destination; // declaring the 3D vectors and points
    public float lookRadius = 20f; // defining a radius which is visible in the editor window
    public NavMeshAgent agent; // declaring a navmesh agent, so we can move our Enemy AI

    void Start()
    {
        //Get the navmesh agent component for this navmesh
        agent = GetComponent<NavMeshAgent>();
        //State for enemy ai is set to idle
        state = State.Idle;
        
    } 

  
    void Update()
    { 
        float distance = Vector3.Distance(player.transform.position, transform.position); // declaring distance between Enemy AI and player

        if(distance <= lookRadius) // if the distance is less than or equal to lookRadius
        {
            state = State.Attack;
        }
        else
        {
            state = State.Idle;
        }

        switch (state)
        {
            case State.Idle:
                //Do nothing
                break;
            case State.Attack:
                agent.SetDestination(player.transform.position); //Chase the player 
                break;
        }

    }

    void OnDrawGizmosSelected() //This method will show the radius of the enemy AI
    {
        Gizmos.color = Color.black;
        Gizmos.DrawWireSphere(transform.position,lookRadius); //Drawing a sphere around our enemy AI
    }

    void OnTriggerStay(Collider other) //Caling the collider 
    {
        if (other.CompareTag("Player"))
        {
            player.transform.position = spawnPoint.transform.position;
            respawn.Spawn();
            print("furkna");

        }
        
    }

}
