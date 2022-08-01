using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class KeyBoardController : MonoBehaviour
{
    public event EventHandler OnAttackEvent;
    public PlayerInput playerController;

    public float Horizontal { get; private set; }
    public float Vertical { get; private set; }

    public Vector2 Direction { get { return new Vector2(Horizontal, Vertical); } }
    public Vector2 rawInputMovement { get; set; }

    private void Start()
    {
        OnAttackEvent += Testing_OnSpacePressed;
    }

    public void OnMovement(InputAction.CallbackContext value)
    {
        Vector2 input = value.ReadValue<Vector2>();
        Horizontal = input.x;
        Vertical = input.y;
        rawInputMovement = new Vector2(Horizontal, Vertical);
    }

   private void Testing_OnSpacePressed(object sender, EventArgs e)
    {
        Debug.Log("Attacked");
    }

    public void OnAttack(InputAction.CallbackContext value)
    {
        if (value.started)
        {
            OnAttackEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}