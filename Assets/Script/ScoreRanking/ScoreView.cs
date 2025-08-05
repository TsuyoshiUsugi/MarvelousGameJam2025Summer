using System;
using UnityEngine;
using UnityEngine.UI;

public class ScoreView : MonoBehaviour
{
    [SerializeField] private Text scoreText; 
    
    private void OnEnable()
    {
        ScoreManager.Instance.OnChangeScore += ChangeScore;
        ScoreManager.Instance.ScoreReset();
    }

    private void OnDisable()
    {
        ScoreManager.Instance.OnChangeScore -= ChangeScore;
    }

    void ChangeScore(int score)
    {
        scoreText.text = score.ToString()+ "îtêHÇ◊ÇΩÅI" ;
    }
    
}
