using System;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSelectAttack : MonoBehaviour
{
    public static event Action<PlayerSelectAttack> OnPlayerSelectAttack;

    [SerializeField] private Button _btnAttack;

    private void Start()
    {
        _btnAttack.onClick.AddListener(BtnAttackClicked);
    }

    private void OnDestroy()
    {
        _btnAttack.onClick.RemoveAllListeners();
    }

    public void BtnAttackClicked()
    {
        OnPlayerSelectAttack?.Invoke(this);
    }
}
