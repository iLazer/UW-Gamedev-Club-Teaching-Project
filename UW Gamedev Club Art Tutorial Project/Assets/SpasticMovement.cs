using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class SpasticMovement : MonoBehaviour
{
    [SerializeField] float speed = 3.0f;
    Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        rb.linearVelocity = Random.insideUnitCircle * speed;
    }
}
