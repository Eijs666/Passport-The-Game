using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colorscript : MonoBehaviour


{
    public GameObject cube; // Declaring  the cube which is under the tile controller


    void OnTriggerEnter(Collider other) // When the game objects collide with the object, which is the cube, it should change color
    {

        Renderer cubeRender = cube.GetComponent<Renderer>();    // We are calling the renderer function for the cube, so it appears on the screen
        cubeRender.material.color = Color.green; // We are getting the material color and changing the color to green
    }
}
