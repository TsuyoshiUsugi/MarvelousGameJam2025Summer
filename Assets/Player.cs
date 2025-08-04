using System.Collections;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] int HighPosision = 10;
    [SerializeField] int MiddlePosision = 5;
    [SerializeField] int LowPosision = 0;
    [SerializeField] int DamagedTime;

    private int _gauge;
    private bool _canMove;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_canMove)
        {
            Move();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Soba"))
        {

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
