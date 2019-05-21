using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayController : MonoBehaviour
{

    [SerializeField]
    private GameObject pausePanel;

    // Start is called before the first frame update
    void Awake()
    {
        pausePanel.SetActive(false);

    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
        pausePanel.SetActive(true);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        pausePanel.SetActive(false);
    }

    public void QuitGame()
    {
        Time.timeScale = 1f;
#pragma warning disable CS0618 // Type or member is obsolete
        Application.LoadLevel("MainMenu");
#pragma warning restore CS0618 // Type or member is obsolete
    }
}
