using DG.Tweening;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private float _speed = 0.3f;
    [SerializeField] float _rotationTime;

    private Tweener _tweener;

    private void Start()
    {
        _tweener =
                this.transform.DORotate(new Vector3(0, 360, 0), _rotationTime).
                    SetLoops(-1).
                    SetRelative(true)
                    .SetEase(Ease.Linear);
    }

    void Update()
    {
        transform.position -= new Vector3(_speed * Time.deltaTime, 0);
    }

    private void OnDestroy()
    {
        _tweener?.Kill();
    }
}
