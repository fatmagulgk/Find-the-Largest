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

    public void StartGame()
    {
        DiffucultyLevelSelection();
        RandomTextSelection();
    
    }
    public int RandomTextSelection()
    {
        int randomText = Random.Range(0,2);
        return randomText;
    }
    public void DiffucultyLevelSelection()
    {
        NumberProductionRange(difficultyScale[Random.Range(0,difficultyScale.Length)]);
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
    public void NumberProductionRange(string difficulty)
    {
        Debug.Log(difficulty);
        switch (difficulty)
        {
            case "Easy":
                NumberGeneration(0, 100);
                break;
            case "Medium":
                NumberGeneration(100, 500);
                break;
            case "Hard":
                NumberGeneration(500, 1000);
                break;
            case "Challenging":
                NumberGeneration(1000,5000);
                break;
            case "Legendary":
                NumberGeneration(5000, 10000);
                break;
            default:
                Debug.Log("Unknown difficulty. Please select a valid option.");
                break;
        }
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
