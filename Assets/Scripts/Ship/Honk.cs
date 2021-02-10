using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Honk : MonoBehaviour
{
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            int chance = Random.Range(0, 100);
            AudioManager temp = AudioManager.instance;
            if (!temp.manualVolumeSources[0].isPlaying && !temp.manualVolumeSources[1].isPlaying)
            {
                if (chance > 0)
                {
                    int rand = Random.Range(0, 2);
                    temp.manualVolumeSources[rand].Play();
                }
                else
                {
                    temp.manualVolumeSources[8].Play();
                }
            }
            
        }
    }
}
