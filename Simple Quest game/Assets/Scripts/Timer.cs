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
        // WHen timer reaches zero, you return to the main menu and show final score
        if (!gamePaused) {
            remainingTime -= Time.deltaTime;
        }
        if (remainingTime <= 0)
        {
            remainingTime = 0;
            menu.SetActive(true);
            menuScore.SetActive(true);
            menuScore.GetComponent<Text>().text = "Final score: " + score;
        }
        timerDisplay.GetComponent<Text>().text = "Time left: " + remainingTime.ToString("N0");


    }
    // use awake instead of start to make sure this is only run once during the whole game session
    void Awake() {
        Instance = this;
        gamePaused = true; // game should start with main menu open, so the timer should be paused

    }


    // starting a new game should reset the timer
    public void NewGame()
    {
        timerDisplay.SetActive(true);
        remainingTime = 15.0f;
        gamePaused = false;
    }
}
