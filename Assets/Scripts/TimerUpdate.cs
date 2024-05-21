using System.Collections;
using System.Collections.Generic;
using System;
using TMPro;
using UnityEngine;

public class TimerUpdate : MonoBehaviour
{
    [SerializeField]
    private LevelInfo levelInfo;

    [SerializeField]
    private TMP_Text timerText;

    public void timeUpdate(){
        float time = levelInfo.timeRemaining;

        if(time < 0){
            time = 0;
        }

        TimeSpan ts = TimeSpan.FromSeconds(time);

        timerText.text = string.Format("{0:00}:{1:00}:{2:000}", ts.Minutes);
    }
}
