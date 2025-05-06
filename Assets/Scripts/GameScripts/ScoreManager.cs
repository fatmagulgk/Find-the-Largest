using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : Singeleton<ScoreManager>
{
    public Text Question;
    public int Score=0;

    private void Start()
    {
        
    }
    public void IsTheRightAnswer()
    {
        if (Question.text == GameManager.Instance.rightQuestion)
        {
            Debug.Log("Doðru cevap.Tebrikler" + Question.text);
            AddScore();
            UIManager.Instance.scoreText.text=Score.ToString();     
        }
        else
        {
            Debug.Log("Yanlýþ Cevap"+ Question.text);
            Debug.Log(Question.text + "==" + GameManager.Instance.rightQuestion);
            ExtractionScore();

        }
        GameManager.Instance.GenerateNewQuestion();
    }
    
    public void AddScore()
    {
        Score += 10;
    }
    public void ExtractionScore()
    {
        Score -= 10;
    }
}
