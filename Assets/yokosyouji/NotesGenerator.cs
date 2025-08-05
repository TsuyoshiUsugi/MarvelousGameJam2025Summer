using System;
using UnityEngine;

public class NotesGenerator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] GenerateDeta[] _item;
    //¶¬ˆÊ’u
    [SerializeField] GameObject[] _points;

    [SerializeField] float _generateTime = 3f;
    System.Random _random = new System.Random();

    float _count;
    int _itemAllWeight;
    int _pointlane;

    void Start()
    {

        foreach (GenerateDeta gd in _item)
        {
            _itemAllWeight += gd.Weight;
        }

    }

    // Update is called once per frame
    void Update()
    {
        _count += Time.deltaTime;

        if (_count >= _generateTime)
        {


            int spawanpoint = _random.Next(0, 8);
            _pointlane = 0;
            for (int k = 4; k != 0; k /= 2)
            {
                if (spawanpoint / k != 0)
                {
                    int randomint = _random.Next(1, _itemAllWeight + 1);
                    Debug.Log(randomint);
                    foreach (var gd in _item)
                    {
                        randomint -= gd.Weight;
                        if (randomint <= 0)
                        {
                            Debug.Log(gd.GameObject);
                            Instantiate(gd.GameObject).transform.position = _points[_pointlane].transform.position;
                            break;
                        }
                    }
                   
                }
                _pointlane++;
            }



            _count = 0;
        }


    }


}
[Serializable]
public class GenerateDeta
{
    public GameObject GameObject;
    public int Weight;
}