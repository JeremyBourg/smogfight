using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Countdown : MonoBehaviour
{

    [SerializeField]
    private LevelInfo levelInfo;

    private bool timerActive = false;

    public UnityEvent onTimerChange;
    public UnityEvent onTimerEnd;

    void Start()
    {
        StartTimer();
    }

    void Update()
    {
        if(timerActive){
            if(levelInfo.timeRemaining > 0){
                levelInfo.timeRemaining -= Time.deltaTime;
                onTimerChange.Invoke();
            }
            else{
                levelInfo.timeRemaining = 0;
                timerActive = false;
                onTimerEnd.Invoke();
            }
        }
    }

    public void StartTimer(){
        levelInfo.timeRemaining = levelInfo.timeLimitInSeconds;
        timerActive = true;
    }
}
