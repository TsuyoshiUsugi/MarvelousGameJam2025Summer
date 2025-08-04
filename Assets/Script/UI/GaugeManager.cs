using UnityEngine;
using UnityEngine.UI;

public class GaugeManager : SingletonMonoBehaviour<GaugeManager>
{
    private int _gaugeValue;
    [SerializeField] private int _maxGaugeValue;
    [SerializeField] private Image _gaugeImage;
    
    public void GaugeChange(int changeValue)
    {
        _gaugeValue += changeValue;
        _gaugeImage.fillAmount = _gaugeValue / _maxGaugeValue;
    }
    
}
