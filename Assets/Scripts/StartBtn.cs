using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartBtn : MonoBehaviour
{
    public TMP_InputField inputField;

    public void OnClickBtn()
    {
        if (inputField.text.Length < 1 || inputField.text.Length > 10)
        {
            return;
        }

        DataManager.instance.userName = inputField.text;

        SceneManager.LoadScene("SeongHoonScene");
    }
}
