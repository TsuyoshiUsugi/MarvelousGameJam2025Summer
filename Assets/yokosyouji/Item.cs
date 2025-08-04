using DG.Tweening;
using Unity.VisualScripting;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private float _speed = 0.3f;
    void Update()
    {
        transform.position -=transform.right * _speed;
    }
}
