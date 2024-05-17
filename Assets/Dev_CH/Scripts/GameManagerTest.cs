using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class GameManagerTest : MonoBehaviour
{
    [SerializeField] private GameObject player1;
    [SerializeField] private GameObject player2;
    [SerializeField] private InputField nickname1;
    [SerializeField] private InputField nickname2;

    private PlayerInputManager playerInputManager;
    // Start is called before the first frame update
    public event Action<PlayerInput> onPlayerJoined;
    CharacterController characterController;
    private void Start() {
        characterController = GameObject.FindObjectOfType<CharacterController>();
        playerInputManager = GetComponent<PlayerInputManager>();
    }
    public void OnButtonPlay1(PlayerInput playerInput)
    {
        //playerInputManager.EnableJoining();
        //Instantiate(player1);
    }
    public void OnButtonPlay2()
    {
        //OnButtonPlay1();
        Instantiate(player2);
    }
}
