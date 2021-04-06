using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(SceneManager.GetActiveScene().buildIndex.Equals(0))
            {
                Application.Quit();
            }
            else
            {
                AudioManager.instance.manualVolumeSources[7].Stop();
                AudioManager.instance.manualVolumeSources[3].Stop();
                AudioManager.instance.manualVolumeSources[12].Stop();
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
                AudioManager.instance.manualVolumeSources[6].Stop();
            }
        }
    }
}
