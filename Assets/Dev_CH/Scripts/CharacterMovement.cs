using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class CharacterMovement : MonoBehaviour
{
    private CharacterController controller;
    private Rigidbody2D rigid;
    private Vector2 MoveDirection;
    private float speed = 5f;
    void Awake(){
        controller = GetComponent<CharacterController>();
        rigid = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        controller.OnMoveEvent += Move;
    }

    private void Move(Vector2 direction)
    {
        MoveDirection = direction;
        rigid.velocity = MoveDirection * speed;
    }
    void Update()
    {
        Move(MoveDirection);
    }
}
