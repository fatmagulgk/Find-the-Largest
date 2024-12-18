using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerManager : Singeleton<TimerManager>
{

    //bu script kullanýlmýyor ancak daha 
    [SerializeField] int timeRemaining;
    bool timerControl = true;
    [SerializeField]private Text countdownText;
    
    void Start()
    {

        if (countdownText == null)
        {
            Debug.LogError("Countdown Text is not assigned. Please assign it in the Inspector.");
            return;
        }
        
    }
    IEnumerator TimerRoutine()
    {
        while(timerControl)
        {
            Debug.Log("girdi");

            
            if (timeRemaining <= 0)
            {
                timerControl = false;
            }
            else
            {
                Debug.Log("girdi" + timeRemaining);
                timeRemaining --;
                countdownText.text = timeRemaining.ToString();
            }
            yield return new WaitForSeconds(1f);
            
        }
    }
    public void StartTimer()=> StartCoroutine(TimerRoutine());
    
    //private void Update()
    //{
    //    Debug.Log(timerControl + "timer control");
    //}

}
