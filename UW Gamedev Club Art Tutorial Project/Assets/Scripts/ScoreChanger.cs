using UnityEngine;

public class ScoreChanger : MonoBehaviour
{
    public int scoreChangeAmount = 1;
    public void ChangeScore()
    {
        Score.Instance.score += scoreChangeAmount;
    }
}
