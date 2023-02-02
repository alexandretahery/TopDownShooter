using Assets.Scripts.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerLifeCtr : MonoBehaviour
{
    private LifeModel _lifePlayer { get; set; }

    public LifeFrontCtr LifeFrontCtr;

    private void Start()
    {
        Init();
    }

    private void Init()
    {
        _lifePlayer = new LifeModel(10f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        TakeDamage(collision, "Ennemie");
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        TakeDamage(collision, "Ennemie");
    }

    private void TakeDamage(Collision2D collision, string tag)
    {
        GameObject objCol = collision.gameObject;
        if (objCol.tag == tag)
        {
            var zombieCtr = objCol.GetComponent<ZombieCtr>();
            _lifePlayer.ActualLife += -zombieCtr.EnnemieHit();
            LifeFrontCtr.UpdateValueLifeFill(-zombieCtr.EnnemieHit());
        }
    }
}
