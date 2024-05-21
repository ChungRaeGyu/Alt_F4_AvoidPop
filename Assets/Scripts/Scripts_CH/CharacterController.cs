using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class CharacterController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;
    [SerializeField] Text nicknameInput;
    void Start(){
        nicknameInput.text = DataManager.instance.userName;
        // TODO:캐릭터의 색정해주기
    }
    public void OnMove(InputAction.CallbackContext context){
        Vector2 direction = context.ReadValue<Vector2>().normalized;
        OnMoveEvent?.Invoke(direction);
    }
}
