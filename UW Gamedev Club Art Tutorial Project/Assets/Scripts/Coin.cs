using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Coin : MonoBehaviour
{
    [SerializeField] RandomPoser randomPoser;
    public ScoreChanger scoreChanger;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.TryGetComponent(out Player player))
        {
            scoreChanger.ChangeScore();
            randomPoser.RandomizePosition();
        }
    }
}
