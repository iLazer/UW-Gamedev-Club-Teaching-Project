using UnityEngine;

public class KillDelay : MonoBehaviour
{
    public float delay = 1f;
    private void FixedUpdate()
    {
        delay -= Time.fixedDeltaTime;
        if (delay <= 0)
        {
            Destroy(gameObject);
        }
    }
}
