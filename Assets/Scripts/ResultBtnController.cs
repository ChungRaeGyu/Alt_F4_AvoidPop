using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultBtnController : MonoBehaviour
{
    public void Retry()
    {
        SceneManager.LoadScene("Main");
    }

    public void ToMain()
    {
        SceneManager.LoadScene("Intro");
    }
}
