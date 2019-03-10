using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    float currentTime = 0f;
    public float startingTime = 10f;

    public Text TimerText;
    public GameManager gameManager;

    public float winningAmount =0f;

         
    void Start()
    {
        currentTime = startingTime;
    }

    public void Update()
    {
        currentTime -= Time.deltaTime;

        int seconds = (int)(currentTime % 60);
        int minutes = (int) (currentTime / 60) %60;


        string timerString = string.Format("{0:00}:{1:00}", minutes, seconds);

        TimerText.text = timerString;


        if (currentTime <= 0f && Score.scoreAmount >=winningAmount)
        {
            gameManager.GameIsWon();
        }

        else if (currentTime <=0 && Score.scoreAmount <= winningAmount)
        {
            gameManager.GameHasEnded();
        }


    }




}
    


   

