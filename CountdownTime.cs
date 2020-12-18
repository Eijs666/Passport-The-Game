using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTime : MonoBehaviour
{
    public GameObject textDisplay;
    public int secondsLeft = 45;
    public bool takingAway = false;
    public Respawn respawn;


    void Start()
    {
        //Get the text component (text display) so we can see it in the game.
        textDisplay.GetComponent<Text>().text = "" + secondsLeft;
    }

    void Update()
    {
        //If its not counting down
        if (takingAway == false && secondsLeft > 0)
        {
            //Start counting down
            StartCoroutine(TimerTake());
        }
        //If time is up 
        if (secondsLeft == 0)
        {
            //Respawn to the start
            respawn.Spawn();
            //Add 45 to the timer - start over
            secondsLeft += 45;
        }
    }

    //Subtract -1 from secondsLeft every other second.
    IEnumerator TimerTake()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);
        secondsLeft -= 1;
        if(secondsLeft < 10)
        {
            textDisplay.GetComponent<Text>().text = "" + secondsLeft;
        }
        else
        {
            textDisplay.GetComponent<Text>().text = "" + secondsLeft;
        }
        takingAway = false;
    }

}