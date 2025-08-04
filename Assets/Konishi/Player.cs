using System;
using System.Collections;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] int HighPosision = 10;
    [SerializeField] int MiddlePosision = 5;
    [SerializeField] int LowPosision = 0;
    [SerializeField] int DamagedTime = 2;

    //private int _gauge;
    private bool _canMove = true;

    private Gauge _gauge;

    public Action OnGameOver;//中身、引数、戻り値なしの関数
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _gauge = FindAnyObjectByType<Gauge>();
        OnGameOver += () => { Debug.Log("GameOver"); };//+=することで関数の中に処理を追加できる
        _gauge.SetGauge();
    }

    // Update is called once per frame
    void Update()
    {
        if (_canMove)
        {
            Move();
        }
        if ( _gauge.GaugeValue> _gauge.MaxGauge || _gauge.GaugeValue < _gauge.MinGauge)
        {
            Debug.Log("ゲームオーバー");
            OnGameOver?.Invoke();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Soba"))
        {
            _gauge.GaugeValue += _gauge.SobaValue;
            _gauge.SetGauge();
        }
        if (other.gameObject.CompareTag("Toys"))
        {
            _gauge.GaugeValue -= _gauge.ToysValue;
            _gauge.SetGauge();
        }
        if (other.gameObject.CompareTag("Obstacle"))
        {
            _canMove = false;
            StartCoroutine(Damaged());
        }
    }
    private void Move()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position = new Vector3(0, HighPosision, 0);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position = new Vector3(0, MiddlePosision, 0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position = new Vector3(0, LowPosision, 0);
        }
    }
    IEnumerator Damaged()
    {
        yield return new WaitForSeconds(DamagedTime);
        _canMove = true;
    }
}
