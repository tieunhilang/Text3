using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score = 0 ;

    public Text textScore;

    public void addScore(int point)
    {
        score += point;
        SetScore();
    }
    public void SetScore()
    {
        textScore.text = "Score: " + score.ToString();
    }

}
