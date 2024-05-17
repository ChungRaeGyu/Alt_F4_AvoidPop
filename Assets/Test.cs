using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Test : MonoBehaviour
{
//    public event Action<Vector2> OnMoveEvent;

    public void OnMove(InputValue value){
        Debug.Log("실행" + transform.name);
    }
}
