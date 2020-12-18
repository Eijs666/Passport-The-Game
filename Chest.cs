using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    public GameManager GM; //Referrencing our gamemanager

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GM.EnableTask1(); //Enable Task 2 (Find key to chest) if player is near chest
        }
        if (other.CompareTag("Player") && GM.hasKey == true)
        {
            GM.LoadNextLevel();
            print("GO TO NEXT LEVEL!!!");
        }
    }
}

