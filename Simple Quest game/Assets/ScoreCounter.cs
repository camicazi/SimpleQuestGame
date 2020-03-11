using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    private int m_Score = 0;
    private static ScoreCounter m_Instance;
    public int Score { get { return m_Score; } set { m_Score = value; } }
    public static ScoreCounter Instance { get { return m_Instance; } }

    public void Start()
    {
        if (m_Instance != null) {
            Destroy(this.gameObject);
            return;
        }
        m_Instance = this;
    }
}
