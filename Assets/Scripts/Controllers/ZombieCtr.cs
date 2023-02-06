using Assets.Scripts.Models;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieCtr : MonoBehaviour
{
    private LifeModel _lifeZombie { get; set; }
    private float _ennemieDamage;


    private void Start()
    {
        Init();
    }

    private void Init()
    {
        _lifeZombie = new LifeModel(3f);
        _ennemieDamage = 0.001f;
    }

    public float EnnemieHit()
    {
        return _ennemieDamage;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        TakeDamage(collision, "ProjectilePlayer");
        Debug.Log("Zombie life: " + _lifeZombie.ActualLife);
    }

    private void TakeDamage(Collider2D collision, string tag)
    {
        GameObject objCol = collision.gameObject;
        if (objCol.tag == tag)
        {
            BulletBasicController Bullet = objCol.GetComponent(typeof(BulletBasicController)) as BulletBasicController;
            CheckLife (Bullet.Damage());
        }
    }

    private void CheckLife(float update)
    {
        _lifeZombie.ActualLife += update;
        if (_lifeZombie.ActualLife <= 0)
            Destroy(gameObject);
    }
}
