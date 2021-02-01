using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dock : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            //do end game stuff here
            //play win sound
            ShipInfo.instance.wonGame = true;
            Destroy(collision.gameObject);
        }
    }
}
