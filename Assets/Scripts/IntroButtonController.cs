using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroButtonController : MonoBehaviour
{
    public TMP_InputField inputField;
    [SerializeField] private GameObject rankingPanel;

    public void StartBtn()
    {
        if (inputField.text.Length < 1 || inputField.text.Length > 10)
        {
            return;
        }

        DataManager.instance.userName = inputField.text;

        SceneManager.LoadScene("Main");
    }

    public void LocalStartBtn()
    {
        SceneManager.LoadScene("Main");
    }

    public void RankingBtn()
    {
        rankingPanel.SetActive(true);
    }

    public void CloseRankingPanelBtn()
    {
        rankingPanel.SetActive(false);
    }

    public void ContinueBtn()
    {
        SceneManager.LoadScene("2p");
    }
}
