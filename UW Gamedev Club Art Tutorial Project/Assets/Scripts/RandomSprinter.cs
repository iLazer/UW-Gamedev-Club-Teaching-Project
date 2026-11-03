using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class RandomSprinter : MonoBehaviour
{
    public bool moving = true;
    public float speed = 5f;
    Rigidbody2D rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        targetDir = Random.insideUnitCircle.normalized;
        transform.up = targetDir;
    }

    public void SetMoving(bool value)
    {
        moving = value;
    }

    Vector2 targetDir;
    private void FixedUpdate()
    {
        if (moving)
        {
            rb.linearVelocity = targetDir * speed;
            transform.up = targetDir;
        }
    }
}
