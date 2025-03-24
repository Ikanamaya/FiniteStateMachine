using UnityEngine;

[CreateAssetMenu(fileName = "newPlayerData, menu name = 'Data/Player Data/Base Data")]
public class PlayerData : ScriptableObject
{
    [Header("Movement")]
    public float movementVelocity = 10f;
}
