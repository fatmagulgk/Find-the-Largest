using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OperationImage : MonoBehaviour, IPointerClickHandler
{
    private void Start()
    {
        
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log(gameObject.name + "týklandý");
    }
}
