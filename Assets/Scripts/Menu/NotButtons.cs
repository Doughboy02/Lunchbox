using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NotButtons : MonoBehaviour
{
    private void Start()
    {
        AudioManager.instance.manualVolumeSources[6].Play();
    }

    public void StartGame()
    {
        AudioManager.instance.manualVolumeSources[7].Play();
        AudioManager.instance.manualVolumeSources[6].Stop();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        AudioManager.instance.manualVolumeSources[3].Play();
        
    }

    public void QuitGame()
    {
        AudioManager.instance.manualVolumeSources[3].Play();
        Application.Quit();
    }
}
