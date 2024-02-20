using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainGame : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score = 0;
    private string formatStringScore = "Your score: {0}";
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = string.Format(formatStringScore, score);
    }

    // Update is called once per frame
    void Update()
    {
        if (score < 0)
        {
            scoreText.text = "Hacoeur{ch3at_engine_is_c00l}";
        }
    }
    public void Click(){
        score++;
        scoreText.text = string.Format(formatStringScore, score);
    }
}
