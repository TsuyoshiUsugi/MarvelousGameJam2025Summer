using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Ranking : SingletonMonoBehaviour<Ranking>
{
    [SerializeField]

    RankingScriptableObject _ranking;

    [SerializeField]

    List<RankingView> _rankingView;

    



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UserData data = new();

        data.UserName = NameManeger.Instance.Name;

        data.Score = ScoreManager.Instance.Score;

        _ranking.RankingList.Add(data); 

        _ranking.RankingList.Sort((x,y)=>y.Score - x.Score);

        int count = _ranking.RankingList.Count > _rankingView.Count ? _rankingView.Count : _ranking.RankingList.Count;
        for (int i = 0; i < count; i++) {


            _rankingView[i].ViewChange(_ranking.RankingList[i].UserName, _ranking.RankingList[i].Score.ToString());
          
        
        
        }

    } 

    // Update is called once per frame
   
}
