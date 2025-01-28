using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    private bool paused = false;
    public GameObject panel;

    void Update()
    {
        // Check for Space key to toggle pause
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (paused)
            {
                Time.timeScale = 1; // Resume game
                paused = false;
                panel.SetActive(false);
            }
            else
            {
                Time.timeScale = 0; // Pause game
                paused = true;
                panel.SetActive(true);
            }
        }

        // Check for Escape key to return to the previous scene
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }
}