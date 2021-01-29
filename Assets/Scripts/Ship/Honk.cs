using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Honk : MonoBehaviour
{
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            int rand = Random.Range(0, 2);
            AudioManager temp = AudioManager.instance;
            if(!temp.manualVolumeSources[0].isPlaying && !temp.manualVolumeSources[1].isPlaying)
            {
                temp.manualVolumeSources[rand].Play();
            }
        }
    }
}
