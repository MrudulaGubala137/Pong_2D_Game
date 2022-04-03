using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverpanel;
    ScoreManager scoreManager;
    public Text winText;
    // Start is called before the first frame update
    void Start()
    {
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
}
