using Assets.Scripts.Extensions;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovementController : MonoBehaviour
{
    //MOUVEMENT PART
    public float speed;
    public Platforme platforme;
    public FloatingJoystick joystick;
    public KeyBoardController keyBoardController;

    //ANIMATION PART
    [SerializeField]
    private SpriteRenderer _spriteRenderer;
    [SerializeField]
    private Animator _animator;
    public AminationModel aminationModel;

    //CAMERA
    [SerializeField]
    public float size;

    private Vector2 directionOld;
    private Vector2 direction;
    // Start is called before the first frame update
    void Start()
    {
        direction = Vector2.zero;
        directionOld = Vector2.zero;
        aminationModel = new AminationModel(_spriteRenderer, _animator);
        Camera.main.orthographicSize = size;
    }

    // Update is called once per frame
    void Update()
    {
        HandleMouvement(transform);
    }

    private void HandleMouvement(Transform transform)
    {
        switch (platforme)
        {
            case Platforme.PC:
                joystick.enabled = false;
                direction = keyBoardController.Direction.normalized;
                Vector2 worldPosition = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
                transform.LookAt2D(worldPosition - new Vector2(transform.position.x, transform.position.y));
                break;
            case Platforme.Mobile:
                keyBoardController.PlayerController.enabled = false;
                direction = Vector2.up * joystick.Vertical + Vector2.right * joystick.Horizontal;
                if (direction != Vector2.zero)
                    directionOld = direction;
                transform.LookAt2D(new Vector3(directionOld.x, directionOld.y, 0));
                break;
            default:
                break;
        }
        aminationModel.SetAnimationSpeed(direction.magnitude * 2);
        transform.position += new Vector3(direction.x, direction.y).normalized * speed * Time.deltaTime;
        Camera.main.transform.position = new Vector3(transform.position.x, transform.position.y + 3f, -10);
    }
}
