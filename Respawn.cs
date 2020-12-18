using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject spawnPoint;
    public float delay = 1f;


    void FixedUpdate()
    {
        if (transform.position.y <= -2)
        {
            StartCoroutine(WaitSeconds(delay)); // We are calling the Spawn() method after 2 seconds
            Spawn();
        }   
    }

    public void Spawn()
    {
        transform.position = spawnPoint.transform.position; // Player position respawns in SpawnPoint;
    }

    IEnumerator WaitSeconds(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
    }
}