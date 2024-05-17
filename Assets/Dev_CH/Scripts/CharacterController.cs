using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;
    private PlayerInput playerinput;
    private InputAction inputAction;
    void Start(){
        playerinput.currentActionMap= inputAction.actionMap;
    }
    public void OnMove(InputAction.CallbackContext context){
        Vector2 direction = context.ReadValue<Vector2>().normalized;
        Debug.Log(transform.name);
        OnMoveEvent?.Invoke(direction);
        
    }
}
