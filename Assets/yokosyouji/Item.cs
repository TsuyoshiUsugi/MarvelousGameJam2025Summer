using DG.Tweening;
using Unity.VisualScripting;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private float _speed = 0.3f;
    void Update()
    {
        transform.position -= new Vector3(_speed * Time.deltaTime,0);
    }
}
