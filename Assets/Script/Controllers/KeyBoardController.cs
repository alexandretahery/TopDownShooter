using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class KeyBoardController : MonoBehaviour
{
    public float Horizontal { get; private set; }
    public float Vertical { get; private set; }

    Vector2 Direction { get { return new Vector2(Horizontal, Vertical); } }

    void Start()
    {
        gameObject.SetActive(false);
    }


}