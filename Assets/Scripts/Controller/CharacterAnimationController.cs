using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationController : AnimationController
{
    // Start is called before the first frame update

    [SerializeField] new SpriteRenderer renderer;
    private static readonly int speed = Animator.StringToHash("speed");

    void Start()
    {
        controller.OnMoveEvent += Anim;
    }

    private void Anim(Vector2 vector)
    {
        animator.SetBool(speed,vector.magnitude>0.1f);
        if(vector.x<0)
            renderer.flipX = true;
        else if(vector.x>0)
            renderer.flipX = false;
    }   
}
