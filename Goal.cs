using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField] //So you can see private variables in unity editor
    public GameManager GM;

    void Start()
    {
        GM.GetComponent<GameManager>(); //Instantiate gamemanager so we can call its functions
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player")) //If player enters the goal
        {
            GM.LoadNextLevel(); //Load nextlevel
            print("NEXT LEVEL");
        }
    }
}
