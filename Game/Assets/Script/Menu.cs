using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{

    public GameObject commandCanvas;

    public GameObject creditsCanvas;



    public void creditsMenu()
    {
        if (creditsCanvas.activeSelf)
        {
            creditsCanvas.SetActive(false);
        }
        else
        {
            creditsCanvas.SetActive(true);
        }
    }

    public void commandMenu()
    {
        if (commandCanvas.activeSelf)
        {
            commandCanvas.SetActive(false);
        }
        else
        {
            commandCanvas.SetActive(true);
        }
    }

 void Start()
    {
        commandCanvas.SetActive(false);
        creditsCanvas.SetActive(false);
    }



    public void MoveToScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }

    public void QuitGame()
    {
            Debug.Log("qzd");
        #if !UNITY_WEBGL
            Application.Quit();
        #endif
    }



}
