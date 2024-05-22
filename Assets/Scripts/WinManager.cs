using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class WinManager : MonoBehaviour
{
    [SerializeField]
    private LevelInfo levelInfo;

    [SerializeField]
    private TMP_Text timeText;

    private void Start() {
        float finalTime = levelInfo.timeLimitInSeconds - levelInfo.timeRemaining;
        TimeSpan ts = TimeSpan.FromSeconds(finalTime);
        timeText.text = string.Format("{0:00}:{1:00}:{2:000}", ts.Minutes, ts.Seconds, ts.Milliseconds);
    }

    public void RestartGame(){
        SceneManager.LoadScene("SceneAccueil");
    }
}
