using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
public class invisible : MonoBehaviour
{
 
    Slider hpSlider;
    private Countdown TimerScript;


    // Use this for initialization
    void Start()
    {
        //タグ HPbarを見つけてそれのSliderを取得 hpSliderに代入
        hpSlider = GameObject.FindWithTag("HPbar").GetComponent<Slider>();
        //
        GameObject Timer = GameObject.FindWithTag("Timer");
        TimerScript = Timer.GetComponent<Countdown>();
    }

    //ボタンを押したときに以下を実行
    public void OnClick()
    {
        Button btn = GetComponent<Button>();

        hpSlider.value -= 150f;

        Countdown.CountDownTime -= 10F;

        btn.interactable = false;

        Invoke("Redisplay", 0.5f);

        if(hpSlider.value == 0)
        {
            SceneManager.LoadScene("End");
        }

    }

    void Redisplay(){
        Button btn = GetComponent<Button>();
        btn.interactable = true;
    }
}