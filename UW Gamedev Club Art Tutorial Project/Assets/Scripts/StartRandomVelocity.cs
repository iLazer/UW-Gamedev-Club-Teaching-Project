using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class StartRandomVelocity : MonoBehaviour
{
    public float startSpeed = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<Rigidbody2D>().linearVelocity = Random.insideUnitCircle.normalized * startSpeed;
    }
}
