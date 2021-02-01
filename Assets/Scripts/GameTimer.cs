using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    public Text timerText;

    private float timer = 0.0f;
    private float dialogueTimer = 0.0f;

    private void Update()
    {
        if(!ShipInfo.instance.wonGame)
        {
            timer += Time.deltaTime;
            timerText.text = "Time: " + timer.ToString();

            dialogueTimer += Time.deltaTime;
            if (dialogueTimer > 30.0f)
            {
                int speak = Random.Range(0, 2);
                if(speak == 0)
                {
                    int rand;
                    if(timer >= 60.0f)
                    {
                        rand = Random.Range(9, 12);
                    }
                    else
                    {
                        rand = Random.Range(10, 12);
                    }
                    AudioManager.instance.manualVolumeSources[rand].Play();
                    dialogueTimer = 0.0f;
                }
            }
        }
    }
}
