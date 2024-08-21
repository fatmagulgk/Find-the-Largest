using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerManager : Singeleton<TimerManager>
{


    public int timeRemaining ;
    bool timerControl = true;

    void Start()
    {
        StartCoroutine(TimerRoutine());
    }
    IEnumerator TimerRoutine()
    {
        while(timerControl&& CountdownManager.Instance.processFinishedControl)
        {
            yield return new WaitForSeconds(1f);

            
            if (timeRemaining <= 0)
            {
                timerControl = false;
            }
            timeRemaining --;
        }
    }
    
}
