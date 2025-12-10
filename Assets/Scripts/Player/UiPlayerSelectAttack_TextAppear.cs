using UnityEngine;

public class UiPlayerSelectAttack_TextAppear : MonoBehaviour
{
    [SerializeField] private CanvasGroup _canvasGroupPlayer;
    [SerializeField] private GameObject _textSelectAnEnemy;
    
    private void OnEnable()
    {
        PlayerSelectAttack.OnPlayerSelectAttack += OnPlayerSelectAttack_ShowUiText;
    }

    private void OnDisable()
    {
        PlayerSelectAttack.OnPlayerSelectAttack -= OnPlayerSelectAttack_ShowUiText;
    }

    public void OnPlayerSelectAttack_ShowUiText(PlayerSelectAttack playerSelectAttack)
    {
        _canvasGroupPlayer.alpha = 0;
        _canvasGroupPlayer.interactable = false;
        _canvasGroupPlayer.blocksRaycasts = false;

        _textSelectAnEnemy.SetActive(true);
    }
}
