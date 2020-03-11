using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public static Timer Instance;
    public float remainingTime = 15.0f;
    public bool gamePaused = true;
    

    void Update()
    {
        // The timer should only be active when the game is not paused
        if (!gamePaused) {
            remainingTime -= Time.deltaTime;
        }

    }
    void Awake() {
        Instance = this;

    }
    //functio for pausigg the timer
    public void pauseGame()
    {
        gamePaused = true;
    }
    //functio for resuming the timer
    public void resumeGame()
    {
        gamePaused = false;
    }


    // starting a new game should reset the timer
    public void newGame()
    {
        remainingTime = 15.0f;
        gamePaused = false;
    }
}
