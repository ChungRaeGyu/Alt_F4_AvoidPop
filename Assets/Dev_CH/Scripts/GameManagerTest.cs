using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerTest : MonoBehaviour
{
    [SerializeField] private GameObject player1;
    [SerializeField] private GameObject player2;
    [SerializeField] private InputField nickname1;
    [SerializeField] private InputField nickname2;
    // Start is called before the first frame update
    public void OnButtonPlay1(){
        Instantiate(player1);
    }
    public void OnButtonPlay2()
    {
        OnButtonPlay1();
        Instantiate(player2);
    }
}
