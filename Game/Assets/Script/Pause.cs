using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class Pause : MonoBehaviour
{

    public GameObject pauseMenu;

    public bool isPaused;

    public GameObject []Button;


    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
        isPaused = true;
        Debug.Log(isPaused);

        for (int i = 0; i < Button.Length; i++)
        {
            Button[i].SetActive(false);
        }
       
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        isPaused = false;
        Debug.Log(isPaused);

        for (int i = 0; i < Button.Length; i++)
        {
            Button[i].SetActive(true);
        }
    }

    public void ChangeStatusPaused()
    {
        if (isPaused)
        {
            ResumeGame();
        }
        else
        {
            PauseGame();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
       ChangeStatusPaused();
        
    }

   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log(isPaused);
            ChangeStatusPaused();
        }
    }

}