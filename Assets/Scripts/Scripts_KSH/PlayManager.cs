using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayManager : MonoBehaviour
{
    [SerializeField] private Text countDownText;
    [SerializeField] private Text currentTimeText;
    [SerializeField] private GameObject rain;
    private float countDown = 3f;
    public float currentTime = 0f;
    private float creationCycle = 1f;

    // Start is called before the first frame update
    void Start()
    {
        // is2P인지 확인해서 세팅하기
        // 1p일때 : 2p 오브젝트 Destroy, 최고점수 불러오기
        // 2p일때 : 2p 오브젝트 살리기

        // 임시
        InvokeRepeating("CreateRain", 3f, creationCycle);
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

    private void CreateRain() // 임시
    {
        float x = Random.Range(-2.5f, 2.5f);
        float y = 4.5f;
        rain.transform.position = new Vector3(x, y, 0f);
        Instantiate(rain);
    }
}
