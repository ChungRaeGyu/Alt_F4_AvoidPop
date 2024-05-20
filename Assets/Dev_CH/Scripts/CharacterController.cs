using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;
    private PlayerInput playerinput;
    public InputActionAsset inputAsset;
    public InputActionMap player;
    public InputAction move;
    void Start(){
        playerinput = GetComponent<PlayerInput>();
        
        // inputAsset = this.GetComponent<PlayerInput>().actions;
        // player = playerinput.currentActionMap;
        // playerinput.defaultActionMap +=inputAsset.FindActionMap("Player2");
        // playerinput.defaultActionMap = null;
    }
    public void OnMove(InputAction.CallbackContext context){
        Vector2 direction = context.ReadValue<Vector2>().normalized;
        Debug.Log(transform.name);
        OnMoveEvent?.Invoke(direction);
    }
}
