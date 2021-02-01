using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    public Text timerText;

    private float timer = 0.0f;

    private void Update()
    {
        if(!ShipInfo.instance.wonGame)
        {
            timer += Time.deltaTime;
            timerText.text = "Time: " + timer;
        }   
    }
}
