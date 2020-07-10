using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    protected int score=0;
    public Text scoreBoard;

    public void ScoreManager()
    {
        score++;
        string s = string.Format("Score : {0:000}",score);
        scoreBoard.text=s;
        
    }

    public int Score
    {
        get { return score; }
    }
}
