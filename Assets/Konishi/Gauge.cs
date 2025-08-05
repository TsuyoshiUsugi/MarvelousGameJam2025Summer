using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Gauge : MonoBehaviour
{
    [SerializeField,Header("–ˆ•bŒ¸‚é’l")] float ChangeGausePerSecond;


    public float MaxGauge = 100;
    public float MinGauge = 0;
    public float SobaValue = 10; 
    public float ToysValue = 10;

    [SerializeField] private float _gaugeValue = 50;
    public float GaugeValue { set { SetGauge(); _gaugeValue = value; } get => _gaugeValue; }

    private Image _image;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GaugeValue >= MaxGauge || GaugeValue <= MinGauge)
        {
            SceneManager.LoadScene("result");
        }
        GaugeValue -= ChangeGausePerSecond * Time.deltaTime;
    }

    public void SetGauge()
    {
        _image.fillAmount = GaugeValue / MaxGauge;
    }
}
