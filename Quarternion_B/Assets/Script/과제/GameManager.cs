using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int score;
    public Text scoreText;

    public GameObject gameOver;
    private bool isGameOver;            

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        isGameOver = false;
    }

    private void Update()
    {
        if (isGameOver)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("GameScene");
                Time.timeScale = 1;
            }
        }
    }

    public void AddScore(int points)
    {
        score += points;
        scoreText.text = $"점수 : {score}";
    }

    public void EndGame()
    {
        isGameOver = true;
        gameOver.SetActive(true);
        Time.timeScale = 0;
    }
}