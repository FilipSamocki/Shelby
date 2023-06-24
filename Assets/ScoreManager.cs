using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI leftScoreText;
    public TextMeshProUGUI rightScoreText;

    public int leftScore;
    public int rightScore;

    public void Start()
    {
        leftScore = 0;
        rightScore = 0;

        leftScoreText.text = leftScore.ToString();
        rightScoreText.text = rightScore.ToString();
    }
    public void IncrementLeftPlayerScore()
    {
        leftScore++;
        leftScoreText.text = leftScore.ToString();
    }
    public void IncrementRightPlayerScore()
    {
        rightScore++;
        rightScoreText.text = rightScore.ToString();
    }
}
