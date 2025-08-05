using UnityEngine;
using UnityEngine.UI;

public class RankingView : MonoBehaviour
{
    [SerializeField]
    Text _name;

    [SerializeField]
    Text _score;

    public void ViewChange(string name,string score)
    {
        _name.text = name;
        _score.text = score;


    }


}
