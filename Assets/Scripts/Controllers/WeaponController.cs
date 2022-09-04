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
        var bullet = Instantiate(Bullet, transform.position, transform.rotation);
        bullet.transform.GetComponent<BulletBasicController>().Setup(transform.position);
    }
}
