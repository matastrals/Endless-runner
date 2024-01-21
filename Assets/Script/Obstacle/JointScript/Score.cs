using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;
    public ObstacleMovement obstacleMovement;
    private bool canScoreUp = true;
    private void Start()
    {
        UpdateScore();
    }

    private void Update()
    {
        //OG = obstacleGround
        float positionOG = ObstacleMovement.position.x;
        if (positionOG <= 5 && positionOG >= 4.95 && canScoreUp)
        {
            StartCoroutine(IncreaseScore());
        }
        UpdateScore();
    }

    IEnumerator IncreaseScore()
    {
        print(score);
        canScoreUp = false;
        yield return new WaitForSeconds(1);
        score++;
        canScoreUp = true;
        print(score);
    }
    private void UpdateScore()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}

    
