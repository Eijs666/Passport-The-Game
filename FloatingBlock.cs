using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingBlock : MonoBehaviour
{
    public float rightLimit = 8f;   //How far the block can move the right limit
    public float leftLimit = -23.0f;    //How far the block can move the left limit
    public float blockSpeed = 10;   //How fast the block moves
    private int blockDirection = 1; //Are we going left(-1) or right(1) - block direction 
    private Vector3 movement; //The blocks movement stored in a vector

    void Update()
    {
        if (transform.position.x > rightLimit)  //If we have reached right limit
        {
            blockDirection = -1; //Go left
        }
        else if (transform.position.x < leftLimit)  //If we have reached left limit
        {
            blockDirection = 1; //Go right
        }
        movement = Vector3.right * blockDirection * blockSpeed * Time.deltaTime; //Formula for moving a transform direction
        transform.Translate(movement); //Move to desired direction
    }
}
