using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationModel
{
    [SerializeField]
    private SpriteRenderer spriteRender;
    [SerializeField]
    private Animator animator;

    public AnimationModel(SpriteRenderer _spriteRenderer, Animator _animator)
    {
        spriteRender = _spriteRenderer;
        animator = _animator;
    }

    public void SetAnimationSpeed(float _speed)
    {
        animator.speed = _speed;
    }

}
