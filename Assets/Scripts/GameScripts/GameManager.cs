using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : Singeleton<GameManager>
{
    [SerializeField] private Text TopText, BottomText;
    public void StartGame()
    {

        Debug.Log("Oyun Baslatildi");
    }
}
