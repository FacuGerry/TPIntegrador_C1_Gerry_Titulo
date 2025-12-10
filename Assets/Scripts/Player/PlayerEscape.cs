using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerEscape : MonoBehaviour
{
    [SerializeField] private PlayerDataSO _playerData;

    [SerializeField] private Button _btnEscape;

    [SerializeField] private float _valueNeededForEscaping;

    private void Start()
    {
        _btnEscape.onClick.AddListener(BtnEscapeClicked);
    }

    private void OnDestroy()
    {
        _btnEscape.onClick.RemoveAllListeners();
    }

    public void BtnEscapeClicked()
    {
        float escapeValue = Random.value;
        escapeValue += (_playerData.baseLuck / 10);
        if (escapeValue >= _valueNeededForEscaping)
        {
            SceneManager.LoadScene("Overworld");
        }
    }
}
