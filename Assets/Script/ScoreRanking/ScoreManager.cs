
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : SingletonMonoBehaviour<ScoreManager>
{
    private int _score;
    [SerializeField] private Text _scoreText;
    
    public void ScoreAdd(int addScore)
    {
        _score += addScore;
        _scoreText.text = _score.ToString();
    }
}
