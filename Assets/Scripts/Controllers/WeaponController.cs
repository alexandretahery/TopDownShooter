using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{


    public GameObject Bullet;

    public EventManager EventManager;

    private void OnEnable() => EventManager.OnAttackEvent += OnAttackPlayer;
    private void OnDisable() => EventManager.OnAttackEvent -= OnAttackPlayer;


    private void OnAttackPlayer(object sender, EventArgs e)
    {
        Debug.Log("ATTACK from WEAPON CTRL");
        Instantiate(Bullet, transform);
    }
}
