
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public int score1;
    public int score2;
    public Text score1Text;
    public Text score2Text;
    BallMovement ball;
    PlayerMovementScript player1;
    PlayerMovementScript player2;
    GameOver game;
   
    private void Start()
    {
        player1 = GameObject.Find("Player1").GetComponent<PlayerMovementScript>();
        player2 = GameObject.Find("Player2").GetComponent<PlayerMovementScript>();
        ball = GameObject.Find("Ball").GetComponent<BallMovement>();
        game= GameObject.Find("GameOverPanel").GetComponent<GameOver>();
       game.gameOverpanel.SetActive(false);
    }
    private void Update()
    {
        if(score1==10||score2==10)
        {
            game.gameOverpanel.SetActive(true);
            game.WinText();
        }
    }
    public void Score1Calculator(int scoreValue)
    {
        score1 = score1 + scoreValue;
        score1Text.text = "Player1: "+score1.ToString();
        ResetGame();
    }

    public void Score2Calculator(int scoreValue)
    {
        score2 = score2 + scoreValue;
        score2Text.text = "Player2: " + score2.ToString();
        ResetGame();
    }

    public void ResetGame()
    {
        ball.RestartPosition();
       
    }


}