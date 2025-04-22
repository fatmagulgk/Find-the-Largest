using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : Singeleton<GameManager>
{
    
    int firstNumber;
    int secondNumber;
    //difficultyScale dizisini enuma cevrilecek
    //diffuculty rastgele olmasýn game sahnesinde secilir olsun.
    //3-2-1 sayacý bitmeden texte yazdýrýlýyor onu düzeltmem gerek.
    
   
    public void StartGame()
    {      
        RandomTextSelection();
        WhichOnIsBig(firstNumber, secondNumber);
        string firstProcess = GenerateExpression(firstNumber);
        string secondProcess = GenerateExpression(secondNumber);
        PrintToText(firstProcess, secondProcess);
    }
    public int RandomTextSelection()
    {
        int randomText = Random.Range(0,2);
        return randomText;
    }
    
    public void NumberGeneration(int minValue,int maxValue)
    {

        
        firstNumber = Random.Range(minValue,maxValue+1);

        do
        {
            secondNumber = Random.Range(minValue, maxValue + 1);
        } while (secondNumber == firstNumber);


    }
    string GenerateExpression(int target)
    {
        while (true)
        {
            int a, b;
            int op = Random.Range(0, 4); // 0:+ 1:- 2:* 3:/

            switch (op)
            {
                case 0: // +
                    a = Random.Range(1, target);
                    b = target - a;
                    return $"{a} + {b}";
                case 1: // -
                    a = Random.Range(target + 1, target + 20);
                    b = a - target;
                    return $"{a} - {b}";
                case 2: // *
                    for (int i = 1; i <= target; i++)
                    {
                        if (target % i == 0)
                        {
                            a = i;
                            b = target / i;
                            if (Random.Range(0, 2) == 0)
                                return $"{a} * {b}";
                        }
                    }
                    break;
                case 3: // /
                    b = Random.Range(1, 10);
                    a = target * b;
                    return $"{a} / {b}";
            }
        }
    }

    public void PrintToText(string firstProcess , string secondProcess)
    {
        if ( RandomTextSelection() == 0)
        {
            UIManager.Instance.TopText.text=firstProcess;
            UIManager.Instance.BottomText.text=secondProcess;
        }else
        {
            UIManager.Instance.TopText.text = secondProcess;
            UIManager.Instance.BottomText.text = firstProcess;
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
