using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{
    public Text textScore;
    private int score;
   
    public void Count(int value)
    {
        score += value;
        textScore.text = score.ToString();
    }
}
