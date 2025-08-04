using UnityEngine;
using UnityEngine.UI;

public class Gauge : MonoBehaviour
{
    public float MaxGauge = 100;
    public float MinGauge = 0;
    public float SobaValue = 10; 
    public float ToysValue = 10;

    public float GaugeValue = 50;

    private Image _image;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetGauge()
    {
        _image.fillAmount = GaugeValue / MaxGauge;
    }
}
