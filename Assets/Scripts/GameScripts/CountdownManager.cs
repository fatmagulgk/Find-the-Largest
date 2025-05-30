using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;


public class CountdownManager : Singeleton<CountdownManager>
{

    [SerializeField]public GameObject CountdownObject;
    [SerializeField]private Text CountdownText;
    int coundownStartNumber = 3;
    public bool processFinishedControl = false;
    Coroutine ietempCoroutine;
    private void Start()
    {
        
    }
    public void StartCountDown() => ietempCoroutine = StartCoroutine(CountdownRoutine());//Tek satirlik metotlari suslu parentez olmadan yazabiliriz.
    IEnumerator CountdownRoutine()
    {
        int count = coundownStartNumber;
        for (int i = 0; i < coundownStartNumber; i++)
        {
            CountdownText.text = count.ToString();
            yield return new WaitForSeconds(0.5f);

            CountdownObject.GetComponent<RectTransform>().DOScale(1, 0.5f).SetEase(Ease.OutBack);
            yield return new WaitForSeconds(1f);
            CountdownObject.GetComponent<RectTransform>().DOScale(0, 0.5f).SetEase(Ease.InBack);
            yield return new WaitForSeconds(0.6f);
            count--;
        }
        processFinishedControl = true;
        UIManager.Instance.ImageControl(processFinishedControl);
        TimerManager.Instance.StartTimer();
        StopCoroutine();
    }
    public void StopCoroutine()
    {
        if (processFinishedControl && ietempCoroutine != null)
        {
            StopCoroutine(ietempCoroutine);
            GameManager.Instance.StartGame();
            UIManager.Instance.pnlCountdown.SetActive(false);
            CountdownObject.SetActive(false);
        }
    }
    protected override void Awake()
    {
        base.Awake();
    }
}
