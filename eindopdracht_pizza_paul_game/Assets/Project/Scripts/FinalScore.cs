﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    Text finalScore;

    void Start()
    {
        finalScore = GetComponent<Text>();
    }


    public void Update()
    {
        finalScore.text = "" + Score.scoreAmount;
    }
}
