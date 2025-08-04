
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : SingletonMonoBehaviour<ScoreManager>
{
    private int _score;
    [SerializeField] private Text _scoreText;
    
    /// <summary>
    /// わんこそばを食べた量を増やす
    /// </summary>
    /// <param name="addScore">変化量</param>
    public void ScoreAdd(int addScore)
    {
        _score += addScore;
        _scoreText.text = _score.ToString();
    }
}
