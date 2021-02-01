using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShipHealth : MonoBehaviour
{
    public static ShipHealth instance;

    [SerializeField]
    private float maxHP = 100f;

    [SerializeField]
    private float hp = 100f;

    public Slider hpSlider;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    public void Heal(float _heal)
    {
        float temp = hp + _heal;
        if(temp <= maxHP)
        {
            hp += _heal;
            hpSlider.value = hp;
        }
    }

    public void Damage(float _damage)
    {
        hp -= _damage;
        AudioManager.instance.manualVolumeSources[5].Play();
        hpSlider.value = hp;

        if (hp <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            //Destroy(gameObject);
        }
    }
}
