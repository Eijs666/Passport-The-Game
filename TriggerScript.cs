using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TriggerScript : MonoBehaviour

{
    public GameObject cube;


    void OnTriggerEnter(Collider other)
    {
        Destroy(cube);
      
    }
}
