using UnityEngine;

public class EnemyTarget : MonoBehaviour
{
    public static EnemyTarget Instance { get; private set; }
    public void Awake()
    {
        Instance = this;
    }
}
