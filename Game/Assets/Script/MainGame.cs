using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class MainGame : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private float score = 0;
    private bool autoclick = false;
    // private bool boostClick = false;
    private string formatStringScore = "{0}";
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
            Debug.Log("Hacoeur{ch3at_engine_is_c00l}");
        }

        if (score >= 100)
        {
           SceneManager.LoadScene(2);
        }
    }
    public void Click(){
        score++;
        scoreText.text = string.Format(formatStringScore, score);
    }
}
