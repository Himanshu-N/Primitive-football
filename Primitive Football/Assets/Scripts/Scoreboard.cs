using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scoreboard : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI ScoreText;
    void Update()
    {
        if (PlayerPrefs.GetInt("Score") > 0)
        {
            ScoreText.text = "Score "+ PlayerPrefs.GetInt("Score") +"/3";
        }
    }
}
