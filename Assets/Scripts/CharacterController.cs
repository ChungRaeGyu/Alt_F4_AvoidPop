using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterController : MonoBehaviour
{
    public event Action<Vector2> onMoveEvent;

    public GameObject[] characters;

    void Strt()
    {
        characters[DataManager.instance.characterNum].SetActive(true);
    }

    public void OnMove(InputAction.CallbackContext context){
        Vector2 direction = context.ReadValue<Vector2>().normalized;
        onMoveEvent?.Invoke(direction);
    }
}
