using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DurationTextControl : MonoBehaviour
{
    [SerializeField] public int _time;

    public Text Text;

    private float WaitingTime = 1f;
    private float CurrentTime = 0f;
    private void Awake()
    {
        Text = GetComponent<Text>();
    }
    private void Update()
    {
        CurrentTime += Time.deltaTime;
        if (CurrentTime >= WaitingTime)
        {
            _time--;
            Text.text = _time.ToString();
            CurrentTime = 0f;
        }
    }
    //processcontrolden sonra çalýþacak ve geriye doðru sayacak

}
