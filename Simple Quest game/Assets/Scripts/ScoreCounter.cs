using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Code based on example by DajBuzi found in unity forum: https://answers.unity.com/questions/773097/keep-track-on-score-when-objects-are-destroyed.html
// This one links to score canvas and displays the score as text on it
public class ScoreCounter : MonoBehaviour
{
    private int m_Score = 0;
    private static ScoreCounter m_Instance;
    public int Score { get { return m_Score; } set { m_Score = value; } }
    public static ScoreCounter Instance { get { return m_Instance; } }
    public Text scoreText;

    
    public void Start()
    {
        m_Instance = this;
        scoreText.text = "Score: " + Score.ToString();
    }
    public void Update()
    {
        scoreText.text = "Score: " + Score.ToString();  // Feels like this solution is needlessly resource intensive, might make ti more efficient later
    }
}