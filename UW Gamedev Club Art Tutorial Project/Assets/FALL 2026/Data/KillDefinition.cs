using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "KillDefinition", menuName = "ScriptableObjects/KillDefinition", order = 1)]
public class KillDefinition : ScriptableObject
{
    public List<KillDefinition> targets;

    public bool CanKill(KillDefinition other)
    {
        return targets.Contains(other);
    }
}
