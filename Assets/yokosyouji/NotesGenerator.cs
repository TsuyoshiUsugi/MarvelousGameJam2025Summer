using System;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.Rendering;

public class NotesGenerator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] GameObject _soba;
    //[SerializeField] GameObject _toys;
    //[SerializeField] GameObject _obstacle;
    //¶¬ˆÊ’u
    [SerializeField] GameObject[] _points;

    [SerializeField] float _generateTime = 3f;
    
    
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
            System.Random _random = new System.Random();
            int num =_random.Next(0,3);
            Instantiate(_soba, _points[num].transform.position,Quaternion.identity);

            Debug.Log(num);
            _count = 0;
        }

    }




}
