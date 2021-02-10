using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NotButtons : MonoBehaviour
{
    public GameObject startButton;
    public GameObject quitButton;
    public GameObject continueButton;
    public GameObject theText;

    private void Start()
    {
        AudioManager.instance.manualVolumeSources[6].Play();
    }

    public void PlayButton()
    {
        AudioManager.instance.manualVolumeSources[7].Play();
        startButton.SetActive(false);
        quitButton.SetActive(false);
        continueButton.SetActive(true);
        theText.SetActive(true);
    }

    public void StartGame()
    {
        AudioManager.instance.manualVolumeSources[7].Play();
        AudioManager.instance.manualVolumeSources[6].Stop();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        AudioManager.instance.manualVolumeSources[3].Play();
        AudioManager.instance.manualVolumeSources[12].Play();
    }

    public void QuitGame()
    {
        AudioManager.instance.manualVolumeSources[7].Play();
        Application.Quit();
    }
}
