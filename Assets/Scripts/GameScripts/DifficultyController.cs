using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class DifficultyController : PersistentSingleton<DifficultyController>
{
    [SerializeField] private Button btnEasy;
    [SerializeField] private Button btnMedium;
    [SerializeField] private Button btnHard;
    [SerializeField] private Button btnChallenging;
    [SerializeField] private Button btnLegendary;
    [SerializeField] private GameObject pnlDiffuculty;
    private void Start()
    {
        ButtonController();
        ButtonSendingText();
        ButtonListener();

    }

    public void ButtonController()
    {
        btnEasy.GetComponent<CanvasGroup>().DOFade(1, 1f);
        btnMedium.GetComponent<CanvasGroup>().DOFade(1, 1f);
        btnHard.GetComponent<CanvasGroup>().DOFade(1, 1f);
        btnChallenging.GetComponent<CanvasGroup>().DOFade(1, 1f);
        btnLegendary.GetComponent<CanvasGroup>().DOFade(1, 1f);
        
    }
    public void ButtonSendingText()
    {
        btnEasy.GetComponent<Button>().onClick.AddListener(()=> NumberProductionRange("Easy"));
        btnMedium.GetComponent<Button>().onClick.AddListener(() => NumberProductionRange("Medium"));
        btnHard.GetComponent<Button>().onClick.AddListener(() => NumberProductionRange("Hard"));
        btnChallenging.GetComponent<Button>().onClick.AddListener(() => NumberProductionRange("Challenging"));
        btnLegendary.GetComponent<Button>().onClick.AddListener(() => NumberProductionRange("Legendary"));
        Debug.Log("Butona týklandý");
        
    }
    public void ButtonListener()
    {
        btnEasy.GetComponent<Button>().onClick.AddListener(()=> PanelClose());
        btnMedium.GetComponent<Button>().onClick.AddListener(()=> PanelClose());
        btnHard.GetComponent<Button>().onClick.AddListener(()=> PanelClose());
        btnChallenging.GetComponent<Button>().onClick.AddListener(()=> PanelClose());
        btnLegendary.GetComponent<Button>().onClick.AddListener(()=> PanelClose());
    }
    public void PanelClose()
    {
        Debug.Log("kapandý");
        pnlDiffuculty.SetActive(false);
    }
    public void NumberProductionRange(string difficulty)
    {
        Debug.Log(difficulty);

        switch (difficulty)
        {
            case "Easy":
                GameManager.Instance.NumberGeneration(0, 100);
                UIManager.Instance.UiActiveControl();
                break;
            case "Medium":
                GameManager.Instance.NumberGeneration(100, 500);
                UIManager.Instance.UiActiveControl();
                break;
            case "Hard":
                GameManager.Instance.NumberGeneration(500, 1000);
                UIManager.Instance.UiActiveControl();
                break;
            case "Challenging":
                GameManager.Instance.NumberGeneration(1000, 5000);
                UIManager.Instance.UiActiveControl();
                break;
            case "Legendary":
                GameManager.Instance.NumberGeneration(5000, 10000);
                UIManager.Instance.UiActiveControl();
                break;
            default:
                Debug.Log("Unknown difficulty. Please select a valid option.");
                break;
        }
        
    }
}
