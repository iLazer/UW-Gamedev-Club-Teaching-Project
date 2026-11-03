using UnityEngine;
using UnityEngine.Events;

public class Killable : MonoBehaviour
{
    public KillDefinition killDefinition;
    public UnityEvent onDie;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        CheckKill(collision.gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        CheckKill(collision.gameObject);
    }

    public void CheckKill(GameObject other)
    {
        if (other.TryGetComponent(out Killer monster))
        {
            if (monster.killDefinition.CanKill(killDefinition))
            {
                monster.onKill.Invoke();
                onDie.Invoke();
            }
        }
    }

    public void DestroySelf()
    {
        Destroy(gameObject);
    }
}
