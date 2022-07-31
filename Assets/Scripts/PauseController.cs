using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseController : MonoBehaviour
{

    [SerializeField] AudioSource audioSource;
    [SerializeField] GameObject pausedPanel;

  //  private bool paused;

  

    public void PauseGame()
    {
        Time.timeScale = 0;
        audioSource.Pause();
        pausedPanel.SetActive(true);
       
    }

    public void EndPause()
    {
        Time.timeScale = 1;
       //audioSource.Play();
        pausedPanel.SetActive(false);
    }

    public void BackMainMenu()
    {
        Time.timeScale = 1;
        pausedPanel.SetActive(false);
        SceneManager.LoadScene(0);
    }
}
