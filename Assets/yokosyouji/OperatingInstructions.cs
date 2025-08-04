using UnityEngine;
using UnityEngine.UI;

public class OperatingInstructions : MonoBehaviour
{
    [SerializeField] private Image _manualImage;
    bool _imageBool=false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Manual()
    {
        _imageBool =! _imageBool;
        _manualImage.gameObject.SetActive(_imageBool);
    }

}
