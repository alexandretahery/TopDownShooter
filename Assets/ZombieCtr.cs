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
        _ennemieDamage = 0.2f;
    }

    public float EnnemieHit()
    {
        return _ennemieDamage;
    }
}
