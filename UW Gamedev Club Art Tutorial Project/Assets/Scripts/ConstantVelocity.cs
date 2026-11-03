using UnityEngine;

public class ConstantVelocity : MonoBehaviour
{
    public float speed = 5f; // Set the desired constant speed here
    Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        if (rb != null)
        {
            Vector2 direction = rb.linearVelocity.normalized; // Get the current direction of movement
            rb.linearVelocity = direction * speed;
        }
    }
}
