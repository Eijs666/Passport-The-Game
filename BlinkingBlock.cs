using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkingBlock : MonoBehaviour
{
    public float randomNumber1;
    public float randomNumber2;
    
    //The state of blocks visability
    public bool isShown;


    // Start is called before the first frame update
    void Start()
    {
        GenerateRandomNumber();
        InvokeRepeating("HideBlock", 0f, randomNumber1);
        InvokeRepeating("ShowBlock", 0f, randomNumber2);
    }

    // Update is called once per frame
    void Update()
    {
        if (isShown)
        {
            gameObject.GetComponent<Renderer>().enabled = true;
            gameObject.GetComponent<BoxCollider>().enabled = true;
        }
        else if(!isShown)
        {
            //Disable block visability
            gameObject.GetComponent<Renderer>().enabled = false;
            //Disable the block collider
            gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }

    //Generates randomnumber - to randomize the disapearing of blocks
    void GenerateRandomNumber()
    {
        randomNumber1 = Random.Range(4f, 6f);
        randomNumber2 = Random.Range(7f, 10f);

    }

    //Hides the block
    void HideBlock()
    {
        isShown = false;
    }

    //Shows the block
    void ShowBlock()
    {
        isShown = true;
    }
}
