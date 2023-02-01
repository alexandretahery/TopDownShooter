using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerLifeCtr : MonoBehaviour
{
    [SerializeField]
    private float _maxPlayerLife;

    [SerializeField]
    private float PLACEHOLDER_DmgPlayer;

    public LifeFrontCtr LifeFrontCtr;

    private float _actualLife;

    private void Start()
    {
        Init();
    }

    private void Init()
    {
        _actualLife = _maxPlayerLife;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _actualLife += -PLACEHOLDER_DmgPlayer;
        LifeFrontCtr.UpdateValueLifeFill(-PLACEHOLDER_DmgPlayer);
    }
}
