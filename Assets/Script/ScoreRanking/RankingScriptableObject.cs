using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "RankingScriptableObject", menuName = "Scriptable Objects/RankingScriptableObject")]
public class RankingScriptableObject : ScriptableObject
{
    [SerializeField] public List<UserData> ranking = new List<UserData>();
}

[Serializable]
public class UserData
{
    public string UserName;
    public int Score;
}