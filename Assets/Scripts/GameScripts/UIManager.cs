using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using Unity.VisualScripting;
using UnityEngine.EventSystems;


public class UIManager : Singeleton<UIManager>
{
    [SerializeField] private GameObject TimeAndScorePanel;
    [SerializeField] public GameObject CompareAndCollectPointsImage;
    [SerializeField] private GameObject TopRectangle,BottomRectangle;
    [SerializeField] public Text TopText;
    [SerializeField] public Text BottomText;
    [SerializeField] public GameObject pnlCountdown;
    [SerializeField] public Text scoreText;


    public void UpdateTheStageScreen()
    {
        
        TimeAndScorePanel.GetComponent<CanvasGroup>().DOFade(1, 1f);
        CompareAndCollectPointsImage.GetComponent<CanvasGroup>().DOFade(1, 1f);

        TopRectangle.GetComponent<RectTransform>().DOLocalMoveX(0,1f).SetEase(Ease.OutBack);
        BottomRectangle.GetComponent<RectTransform>().DOLocalMoveX(0, 1f).SetEase(Ease.OutBack);
      
    }
    public void UiActiveControl()
    {
        
        TimeAndScorePanel.SetActive(true);
        CountdownManager.Instance.CountdownObject.SetActive(true);
        pnlCountdown.SetActive(true);
        TopRectangle.SetActive(true);
        BottomRectangle.SetActive(true);
        CompareAndCollectPointsImage.SetActive(true);
        UpdateTheStageScreen();
        CountdownManager.Instance.StartCountDown();
    }
    public void ImageControl(bool processControl)
    {
        CompareAndCollectPointsImage.GetComponent<CanvasGroup>().DOFade(0, 1f);     
    }
}
