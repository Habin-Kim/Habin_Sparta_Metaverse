using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    static GameManager gameManager;
    public static GameManager Istance
    {
        get { return gameManager; }
    }

    private int currentScore = 0;

    UIManager uIManager;
    public UIManager UIManager
    {
        get { return uIManager; }
    }

    private void Awake()
    {
        gameManager = this;
        uIManager = FindObjectOfType<UIManager>();
    }

    public void Start()
    {
        uIManager.UpdateScore(0);
    }

    public void GameOver()
    {
        Debug.Log("Game Over");
        uIManager.SetRestart();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void AddScore(int score)
    {
        currentScore += score;
        Debug.Log("Scroe: " + currentScore);
        uIManager.UpdateScore(currentScore);
    }
}
