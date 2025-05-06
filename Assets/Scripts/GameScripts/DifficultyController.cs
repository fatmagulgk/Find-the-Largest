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

    public Difficulty _df;
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
        btnEasy.GetComponent<Button>().onClick.AddListener(()=> NumberProductionRange(Difficulty.Easy));
        btnMedium.GetComponent<Button>().onClick.AddListener(() => NumberProductionRange(Difficulty.Medium));
        btnHard.GetComponent<Button>().onClick.AddListener(() => NumberProductionRange(Difficulty.Hard));
        btnChallenging.GetComponent<Button>().onClick.AddListener(() => NumberProductionRange(Difficulty.Challenging));
        btnLegendary.GetComponent<Button>().onClick.AddListener(() => NumberProductionRange(Difficulty.Legendary));
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
    public void NumberProductionRange(Difficulty difficulty)
    {
        Debug.Log(difficulty);

        switch (difficulty)
        {
            case Difficulty.Easy:
                GameManager.Instance.MinMaxNumberHolder(0, 100);
                UIManager.Instance.UiActiveControl();
                break;
            case Difficulty.Medium:
                GameManager.Instance.MinMaxNumberHolder(100, 500);
                UIManager.Instance.UiActiveControl();
                break;
            case Difficulty.Hard:
                GameManager.Instance.MinMaxNumberHolder(500, 1000);
                UIManager.Instance.UiActiveControl();
                break;
            case Difficulty.Challenging:
                GameManager.Instance.MinMaxNumberHolder(1000, 5000);
                UIManager.Instance.UiActiveControl();
                break;
            case Difficulty.Legendary:
                GameManager.Instance.MinMaxNumberHolder(5000, 10000);
                UIManager.Instance.UiActiveControl();
                break;
            default:
                Debug.Log("Unknown difficulty. Please select a valid option.");
                break;
        }
        
    }
}
public enum Difficulty
{
    Easy,
    Medium,
    Hard,
    Challenging,
    Legendary,

}
