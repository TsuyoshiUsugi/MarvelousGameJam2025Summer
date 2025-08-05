
using System;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : SingletonMonoBehaviour<ScoreManager>
{
    public int Score { get;private set; }
    public Action<int> OnChangeScore;
    
    /// <summary>
    /// わんこそばを食べた量を増やす
    /// </summary>
    /// <param name="addScore">変化量</param>
    public void ScoreAdd(int addScore)
    {
        Score += addScore;
        OnChangeScore?.Invoke(Score);
    }

    public void ScoreReset()
    {
        Score = 0;
    }
}
