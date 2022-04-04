using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverpanel;
    ScoreManager scoreManager;
    public Text winText;
    public Button playAgain;
    // Start is called before the first frame update
    void Start()
    {
        playAgain.onClick.AddListener(PlayAgain);
        // gameOverpanel.SetActive(true);
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }
    
    public void WinText()
    {
        
        if (scoreManager.score1==10)
        {
            winText.text = "Player1 Won";
        }
        else
        {
            winText.text = "Player2 Won";
        }
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene(1);
    }
}
