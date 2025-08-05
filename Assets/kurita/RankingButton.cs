using UnityEngine;
using UnityEngine.UI;

public class RankingButton : MonoBehaviour
{
    [SerializeField]
    private Image _rankingUI;
    bool _rankingBool = false;

    public void Manual()
    {
        _rankingBool =! _rankingBool;
        _rankingUI.gameObject.SetActive(_rankingBool);
       
    }
}
