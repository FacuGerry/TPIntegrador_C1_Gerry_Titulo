using System;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSelectEnemy : MonoBehaviour
{
    public event Action OnEnemySelected;
    [SerializeField] private Button _selectButton;
    private CanvasGroup _canvasGroup;

    private void Awake()
    {
        _canvasGroup = GetComponent<CanvasGroup>();
    }

    private void Start()
    {
        _canvasGroup.alpha = 0;
        _canvasGroup.interactable = false;
        _canvasGroup.blocksRaycasts = false;

        _selectButton.onClick.AddListener(SelectEnemy);
    }

    private void OnEnable()
    {
        PlayerSelectAttack.OnPlayerSelectAttack += OnPlayerSelectAttack_ShowEnemyButtons;
    }

    private void OnDisable()
    {
        PlayerSelectAttack.OnPlayerSelectAttack -= OnPlayerSelectAttack_ShowEnemyButtons;
    }

    private void OnDestroy()
    {
        _selectButton.onClick.RemoveAllListeners();
    }

    public void SelectEnemy()
    {
        OnEnemySelected?.Invoke();
    }

    public void OnPlayerSelectAttack_ShowEnemyButtons(PlayerSelectAttack playerSelectAttack)
    {
        _canvasGroup.alpha = 1;
        _canvasGroup.interactable = true;
        _canvasGroup.blocksRaycasts = true;
    }
}