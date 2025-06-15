using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text RightScoreText;
    public Text LeftScoreText;
    public BallBehaviour ball;
    
    private int plRscore;
    private int plLscore;
  
    public void RightPlayerScore()
    {
        plRscore++;
        RightScoreText.text = plRscore.ToString();
        ball.resetPos();
    }
    public void LeftPlayerScore()
    {
        plLscore++;
        LeftScoreText.text = plLscore.ToString();
        ball.resetPos();
        
    }
    
}
