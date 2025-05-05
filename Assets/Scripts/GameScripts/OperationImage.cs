using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class OperationImage : MonoBehaviour, IPointerClickHandler
{ 
    private void Start()
    {
        
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log(gameObject.name + "týklandý");
        ScoreManager.Instance.Question = gameObject.GetComponentInChildren<Text>();
        ScoreManager.Instance.IsTheRightAnswer();

    }
}
