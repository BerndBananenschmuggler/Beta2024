using UnityEngine;

[CreateAssetMenu(fileName = "PlayerStatsScriptable",
    menuName = "ScriptableObjects/PlayerStatsScriptable")]

// Theo Kaminsky, Theo#6969
public class PlayerStatsScriptable : ScriptableObject
{
    public float movementSpeed;
    public float rotationSpeed;
}
