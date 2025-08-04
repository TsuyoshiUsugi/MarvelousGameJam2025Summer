using System;
using UnityEngine;

public class NotesGenerator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] GameObject _soba;
    //[SerializeField] GameObject _toys;
    //[SerializeField] GameObject _obstacle;
    //¶¬ˆÊ’u
    [SerializeField] GameObject _points;

    [SerializeField] float _generateTime= 3f;
    float _count;
    
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        _count += Time.deltaTime;
        if (_count > _generateTime)
        {
            Instantiate(_soba,_points.transform.position,Quaternion.identity);


            _count = 0;
        }

    }




}
