using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

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
    }
}
