using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : Singeleton<GameManager>
{
    [SerializeField] private Text TopText, BottomText;
    string[] difficultyScale = { "Easy", "Medium", "Hard", "Challenging", "Legendary" };
    //difficultyScale dizisini enuma cevrilecek
    //diffuculty rastgele olmasýn game sahnesinde secilir olsun.
    //3-2-1 sayacý bitmeden texte yazdýrýlýyor onu düzeltmem gerek.

    public void StartGame()
    {
        
        RandomTextSelection();
        
    
    }
    public int RandomTextSelection()
    {
        int randomText = Random.Range(0,2);
        return randomText;
    }
    
    public void NumberGeneration(int minValue,int maxValue)
    {
        
        int firstNumber, secondNumber;
        firstNumber = Random.Range(minValue,maxValue+1);

        do
        {
            secondNumber = Random.Range(minValue, maxValue + 1);
        } while (secondNumber == firstNumber);
        PrintToText(firstNumber, secondNumber);
        WhichOnIsBig(firstNumber, secondNumber);

    }
    
    public void PrintToText(int firstNumber , int secondNumber)
    {
        if ( RandomTextSelection() == 0)
        {
            TopText.text=firstNumber.ToString();
            BottomText.text=secondNumber.ToString();
        }else
        {
            TopText.text = secondNumber.ToString();
            BottomText.text = firstNumber.ToString();
        }
    }
    public void WhichOnIsBig(int firstNumber,int secondNumber)
    {
        if (firstNumber > secondNumber)
            Debug.Log("fistNumber is big" + firstNumber + ">" + secondNumber);
        else
            Debug.Log("secondNumber is big" + secondNumber + ">" + firstNumber);
    }
    
}
