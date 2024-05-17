using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayManager : MonoBehaviour
{
    [SerializeField] private Text CountDownText;
    [SerializeField] private Text CurrentTimeText;
    private float countDown = 3f;
    private float currentTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        // is2P���� Ȯ���ؼ� �����ϱ�
        // 1p�϶� : 2p ������Ʈ Destroy, �ְ����� �ҷ�����
        // 2p�϶� : 2p ������Ʈ �츮��
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
            CountDownText.gameObject.SetActive(false);
            CurrentTimeText.gameObject.SetActive(true);
            currentTime += Time.deltaTime;
            CurrentTimeText.text = currentTime.ToString("N2");
        }
    }

    private void CountDown()
    {
        if(countDown >= 0f && countDown < 1f) 
        {
            CountDownText.text = "1";
        }
        else if(countDown >= 1f && countDown < 2f)
        {
            CountDownText.text = "2";
        }
        else if(countDown >= 2f && countDown <= 3f)
        {
            CountDownText.text = "3";
        }
    }
}
