using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    //Refer to the players position
    Transform player;

    // Start is called before the first frame update
    void Start()
    {
        //Finding the player in the game
        player = GameObject.FindGameObjectWithTag("Player").transform;
        print("Found Player");
    }

    // Update is called once per frame
    void Update()
    {
        //Rotates the transform so the forward vector points at players current position.
        transform.LookAt(player);
    }
}
