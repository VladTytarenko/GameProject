﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoButton : MonoBehaviour
{
    public GameObject setting;
    public Button button;

    void settingBoard()
    {
        GameObject obj = UICamera.first.transform.parent.gameObject;
        NGUITools.AddChild(obj, setting);
    }

    void Start()
    {
        button.signalOnClick.AddListener(settingBoard);
    }
} 