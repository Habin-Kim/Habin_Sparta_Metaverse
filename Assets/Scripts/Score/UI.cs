using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{
    TextMeshProUGUI bestScoreText;


    void Start()
    {        
        bestScoreText = GameObject.Find("BestScoreText").GetComponent<TextMeshProUGUI>();
        if(bestScoreText == null)
        {
            Debug.Log("BestScore is Null");
            return;
        }
        int bestScore = PlayerPrefs.GetInt("BestScore", 0);
        bestScoreText.text = "Best Score: " + bestScore.ToString();
    }
}
