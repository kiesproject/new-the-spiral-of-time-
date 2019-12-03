using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HPbar : MonoBehaviour
{

    Slider hpSlider;

    // Use this for initialization
    void Start()
    {

        hpSlider = GetComponent<Slider>();

        float maxHp = 2000f;
        float nowHp = 2000f;


        //スライダーの最大値の設定
        hpSlider.maxValue = maxHp;

        //スライダーの現在値の設定
        hpSlider.value = nowHp;


    }

}
