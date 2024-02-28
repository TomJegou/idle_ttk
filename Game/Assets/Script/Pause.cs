using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class Pause : MonoBehaviour
{

    public GameObject pauseMenu;

    public bool isPaused;

    public Button[] buttons; // Change GameObject[] to Button[]

    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
        isPaused = true;
        Debug.Log(isPaused);

        foreach (Button button in buttons)
        {
            button.interactable = false;
        }
       
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        isPaused = false;
        Debug.Log(isPaused);

        foreach (Button button in buttons)
        {
            button.interactable = true;
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
