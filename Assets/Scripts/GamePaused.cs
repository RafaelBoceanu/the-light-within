using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePaused : MonoBehaviour
{
    Canvas canvas;
    bool isPaused;

    private void Awake()
    {
        canvas = GetComponent<Canvas>();

        canvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P))
        {
            if (isPaused)
            {
                OnResumeGame();
            }
            else
            {
                OnPauseGame();
            }
        }
    }

    public void OnResumeGame()
    {
        canvas.enabled = false;
        Time.timeScale = 1f;
        isPaused = false;
        Cursor.visible = false;
    }
    public void OnQuitGame()
    {
        Application.Quit();
    }

    void OnPauseGame()
    {
        canvas.enabled = true;
        Time.timeScale = 0f;
        isPaused = true;
        Cursor.visible = true;
    }
}
