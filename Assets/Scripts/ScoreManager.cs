using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text txtScore;
    
    float score = 0.0f;
    
    void Update()
    {
        score += Time.deltaTime;
        txtScore.text = score.ToString("N2");
    }
}
