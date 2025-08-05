using System;
using System.Collections;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] int HighPosision = 10;
    [SerializeField] int MiddlePosision = 5;
    [SerializeField] int LowPosision = 0;
    [SerializeField] float DamagedTime = 2;
    [SerializeField] AudioClip[] audioClips;

    //private int _gauge;
    private bool _canMove = true;

    private Gauge _gauge;
    private AudioSource _audioSource;

    public Action OnGameOver;//引数戻り値なしの関数を作成
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _gauge = FindAnyObjectByType<Gauge>();
        _audioSource = GetComponent<AudioSource>();
        OnGameOver += () => { Debug.Log("GameOver"); };//+=で関数の中に処理を追加できる
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
            Debug.Log("�Q�[���I�[�o�[");
            OnGameOver?.Invoke();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Soba"))
        {
            _gauge.GaugeValue += _gauge.SobaValue;
            _audioSource.PlayOneShot(audioClips[1]);
            ScoreManager.Instance.ScoreAdd(1);
        }
        if (other.gameObject.CompareTag("Toys"))
        {
            _gauge.GaugeValue -= _gauge.ToysValue;
            _audioSource.PlayOneShot(audioClips[0]);
        }
        if (other.gameObject.CompareTag("Obstacle"))
        {
            _canMove = false;
            _audioSource.PlayOneShot(audioClips[4]);
            _audioSource.PlayOneShot(audioClips[2]);
            StartCoroutine(Damaged());
        }
    }
    private void Move()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position = new Vector3(0, HighPosision, 0);
            _audioSource.PlayOneShot(audioClips[3]);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position = new Vector3(0, MiddlePosision, 0);
            _audioSource.PlayOneShot(audioClips[3]);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position = new Vector3(0, LowPosision, 0);
            _audioSource.PlayOneShot(audioClips[3]);
        }
    }
    IEnumerator Damaged()
    {
        yield return new WaitForSeconds(DamagedTime);
        _canMove = true;
    }
}
