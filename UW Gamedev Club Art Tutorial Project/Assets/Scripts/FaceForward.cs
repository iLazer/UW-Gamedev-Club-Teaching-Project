using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class FaceForward : MonoBehaviour
{
    Rigidbody2D rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public void Update()
    {
        transform.up = rb.linearVelocity.normalized;
    }
}
