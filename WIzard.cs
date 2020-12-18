using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WIzard : MonoBehaviour
{
    public GameObject welcomeText;
    public GameObject questText;
    public GameObject yesbutton;
    public GameObject WelcomeText2;
    public GameObject playerTask1;
    public GameObject playerTask2;

    public bool isPW1;
    public bool isPW2;

    void Start()
    {
        CheckPaludanWizard(); //Checking which paludan wizard we are interacting
        welcomeText.SetActive(false);
        questText.SetActive(false);
        yesbutton.SetActive(false);
    }
    

    //If player enters the radius of plaudan wizard
    private void OnTriggerStay(Collider other)
    {
        if (isPW1)
        {

            if (other.CompareTag("Player"))
            {
                welcomeText.SetActive(true); //Show welcome text
            }
        }

        if (isPW2)
        {
            if (other.CompareTag("Player"))
            {
                questText.SetActive(true); //Shows quest1 text
                yesbutton.SetActive(true); //Shows the button
            }
        }
    }

    //If player leaves the radius of plaudan wizard
    private void OnTriggerExit(Collider other)
    {
        if (isPW1)
        {

            if (other.CompareTag("Player"))
            {
                welcomeText.SetActive(false); //Hide welcome text
            }
        }

        if (isPW2)
        {
            if (other.CompareTag("Player"))
            {
                questText.SetActive(false); //Hide quest1 text
                yesbutton.SetActive(false); //Hide the button
            }
        }
    }

    //Checking for which paludanwizard we are working with
    void CheckPaludanWizard() 
    {
        if(gameObject.tag == "PW1")
        {
            print("PW1");
            isPW1 = true;
            isPW2 = false;
        }
        if (gameObject.tag == "PW2")
        {
            print("PW2");
            isPW1 = false;
            isPW2 = true;
        }

    }

}
