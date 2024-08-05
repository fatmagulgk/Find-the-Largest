using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private Transform Head;
    [SerializeField] private Transform StartButton;

    private void Start()
    {
        HeadDisplacement();
        StartButton.GetComponent<Button>().onClick.AddListener(StartGame);
    }
    public void HeadDisplacement()
    {
        Head.transform.GetComponent<RectTransform>().DOLocalMoveX(0f,1f).SetEase(Ease.OutBack);
        StartButton.transform.GetComponent<RectTransform>().DOLocalMoveY(-250f,1f).SetEase(Ease.OutBack);
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }
}
