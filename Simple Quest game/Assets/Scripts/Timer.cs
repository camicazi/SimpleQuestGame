using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static Timer Instance;
    public float remainingTime = 15.0f;
    public bool gamePaused = true;
    public GameObject timerDisplay;
    public GameObject menu;
    public GameObject menuScore;
    public GameObject score;

    void Update()
    {
        // The timer should only be active when the game is not paused. Game unpauses once clicking "new game"
        // When timer reaches zero, you return to the main menu, destroy remaining yellow coins, and show final score
        //while counting down the timer shows the remaining time in int form on the linked timerDisplay canvas
        if (!gamePaused)
        {
            remainingTime -= Time.deltaTime;
        }
        if (remainingTime <= 0)
        {
            var gameObjects = GameObject.FindGameObjectsWithTag("YellowCoin");
            for (var i = 0; i < gameObjects.Length; i++)
            {
                Destroy(gameObjects[i]);
            }
            remainingTime = 0;
            menuScore.SetActive(true);
            menuScore.GetComponent<Text>().text = "Final score: " + ScoreCounter.Instance.Score;
            menu.SetActive(true);
        }
        timerDisplay.GetComponent<Text>().text = "Time left: " + remainingTime.ToString("N0");


    }
    // use awake instead of start to make sure this is only run once during the whole game session
    void Awake()
    {
        Instance = this;
        gamePaused = true; // game starts with main menu open, so the timer should be paused

    }


    // starting a new game should reset the timer and score counter and activate the time countdown
    public void NewGame()
    {
        timerDisplay.SetActive(true);
        remainingTime = 15.0f;
        gamePaused = false;
        ScoreCounter.Instance.Score = 0;
    }
}
