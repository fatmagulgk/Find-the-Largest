using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject TimeAndScorePanel;
    [SerializeField] private GameObject CompareAndCollectPointsImage;
    [SerializeField] private GameObject TopRectangle,BottomRectangle;



    private void Start()
    {
        UpdateTheStageScreen();
    }



    public void UpdateTheStageScreen()
    {
        TimeAndScorePanel.GetComponent<CanvasGroup>().DOFade(1, 1f);
        CompareAndCollectPointsImage.GetComponent<CanvasGroup>().DOFade(1, 1f);

        TopRectangle.GetComponent<RectTransform>().DOLocalMoveX(0,1f).SetEase(Ease.OutBack);
        BottomRectangle.GetComponent<RectTransform>().DOLocalMoveX(0, 1f).SetEase(Ease.OutBack);
    }
}
