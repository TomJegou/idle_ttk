using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainGame : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int score = 0;
    private string formatStringScore = "Your score: {0}";
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = string.Format(formatStringScore, score);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Click(){
        score++;
        scoreText.text = string.Format(formatStringScore, score);
    }
}
