using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.UIElements;

public class PlayManager : MonoBehaviour
{
    [SerializeField] private TMP_Text countDownText;
    [SerializeField] private TMP_Text currentTimeText;
    [SerializeField] private GameObject rain;
    [SerializeField] private GameObject barrier;
    private float countDown = 3f;
    public float currentTime = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
        // is2P인지 확인해서 세팅하기
        // 1p일때 : 2p 오브젝트 Destroy, 최고점수 불러오기
        // 2p일때 : 2p 오브젝트 살리기
        Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(countDown >= 0f)
        {
            countDown -= Time.deltaTime;
            CountDown();
        }
        else
        {
            countDownText.gameObject.SetActive(false);
            currentTimeText.gameObject.SetActive(true);
            currentTime += Time.deltaTime;
            currentTimeText.text = currentTime.ToString("N2");
        }
    }

    private void CountDown()
    {
        if(countDown >= 0f && countDown < 1f) 
        {
            countDownText.text = "1";
        }
        else if(countDown >= 1f && countDown < 2f)
        {
            countDownText.text = "2";
        }
        else if(countDown >= 2f && countDown <= 3f)
        {
            countDownText.text = "3";
        }
    }
}
