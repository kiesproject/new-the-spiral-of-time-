using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Disappear : MonoBehaviour
{

    public static float CountDownTime;  // カウントダウンタイム

    Button card;

    // Start is called before the first frame update
    void Start()
    {
        CountDownTime = 100.0F;  // カウントダウン開始秒数をセット
        card = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        CountDownTime -= Time.deltaTime;

        if (CountDownTime <= 90.0F)
        {
            // 非表示にする
            gameObject.SetActive(false);
        }

    }
}
