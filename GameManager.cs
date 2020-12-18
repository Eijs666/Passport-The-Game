using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject introText;
    public GameObject playerTask1;
    public GameObject playerTask2;
    public GameObject gameOverText;

    public bool hasKey;

    void Start()
    {
        Destroy(introText, 5f); //Destroy intro text after 3 seconds

        playerTask1.SetActive(false);
        playerTask2.SetActive(false);
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //Changing levelscene = levelscene + 1 - so we get to the next levelscene
    }

    //When task button is press than call these methods
    public void EnableTask1()
    {
        playerTask1.SetActive(true); //Button is pressed - activate task 1
        playerTask2.SetActive(true); //Button is pressed - activate task 2
    }
    public void EnableTask2()
    {
        playerTask2.SetActive(true); //Button is pressed - activate task 2
    }

    public void GameOver()
    {
        print("Game over!");
        gameOverText.SetActive(true);
    }



}

