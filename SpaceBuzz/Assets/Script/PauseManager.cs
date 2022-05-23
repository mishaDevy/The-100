using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    [SerializeField] private GameObject PauseScreen;
    [SerializeField] private GameObject PauseButton;

    private void Start()
    {
        PauseButton.SetActive(false);
        Invoke("PauseButtonActive", 2);
    }

    public void PauseButtonActive()
    {
        PauseButton.SetActive(true);
    }
    public void PauseGame()
    {
        Time.timeScale = 0;
        PauseScreen.SetActive(true);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        PauseScreen.SetActive(false);
    }

    public void BacktoBase()
    {
        SceneManager.LoadScene("base");
    }
}