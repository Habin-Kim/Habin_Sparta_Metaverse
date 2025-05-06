using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{
    public TextMeshProUGUI bestScoreText;


    void Start()
    {
        bestScoreText = GameObject.Find("BestScoreText").GetComponent<TextMeshProUGUI>();
        int bestScore = PlayerPrefs.GetInt("BestScore", 0);
        bestScoreText.text = "Best Score: " + bestScore.ToString();
    }
}
