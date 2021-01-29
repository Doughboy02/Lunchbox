using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipHealth : MonoBehaviour
{
    public ShipHealth singleton;

    [SerializeField]
    private float maxHP = 100f;

    [SerializeField]
    private float hp = 100f;

    private void Awake()
    {
        if (singleton == null)
            singleton = this;
        else
            Destroy(gameObject);
    }

    public void Heal(float _heal)
    {
        hp += _heal;
    }

    public void Damage(float _damage)
    {
        hp -= _damage;

        //do other stuff later
        if(hp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
