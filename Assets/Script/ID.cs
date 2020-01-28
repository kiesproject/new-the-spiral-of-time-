using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;


public class ID : MonoBehaviour
{

    public Button card;
    List<int> int_list = new List<int>();

    void Start()
    {
        int_list.Add(card.gameObject.GetInstanceID());
        for (int i = 0; i < int_list.Count; i++)
        {
            Debug.Log(int_list[i]);
        }
    }
}
