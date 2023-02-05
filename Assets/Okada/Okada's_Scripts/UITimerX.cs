using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/// <summary>
/// This is UItimer script.
/// </summary>

public class UITimerX : MonoBehaviour
{
    /// <summary> Variable for TimerTextUI</summary>
    [SerializeField, Header("TimerUIText")] TextMeshProUGUI _timerText;

    /// <summary> Variable for Timer</summary>
    float _timer;


    /// <summary>
    /// Method to update timer
    /// </summary>
    void Update()
    {
        TimeCountUpStart();
    }

    /// <summary>CountUpMethod</summary>
    void TimeCountUpStart()
    {
        // Count up every frame
        _timer += Time.deltaTime;

        // Assign time divided by 60 (minute)
        int minute = (int)_timer / 60;

        // Assign the remainder of time divided by 60 (second)
        int second = (int)_timer % 60;

        string minuteText;

        string secondText;


        // If less than 10 (minutes displayed in 1 digit)
        if (minute < 10)
        {
            // Fill in 0 and convert int to string
            minuteText = "0" + minute.ToString();
        }
        else
        {
            // Otherwise, convert int to string
            minuteText = minute.ToString();
        }

        // If the value is less than 10 (seconds is displayed in 1 digit)
        if (second < 10)
        {
            // The same as minutes
            secondText = "0" + second.ToString();
        }
        else
        {
            // Otherwise, The same as minutes
            secondText = second.ToString();
        }
        // display TimerTextUI
        _timerText.text = "Time " + minuteText + ":" + secondText;
    }
}
