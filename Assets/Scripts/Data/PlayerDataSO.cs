using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "PlayerData/PlayerStats")]
public class PlayerDataSO : ScriptableObject
{
    [Header("Base stats")]
    public int baseLife;
    public int baseAttack;
    public int baseDefense;
    public int baseLuck;
}