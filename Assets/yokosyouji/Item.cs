using DG.Tweening;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private float _speed = 0.3f;
    [SerializeField] float _rotationTime;

    Tweener _tweener;
    void Update()
    {
        transform.position -= new Vector3(_speed * Time.deltaTime,0);
        if (gameObject.CompareTag("Soba"))
        {
            _tweener = 
            this.transform.DORotate(new Vector3(0, 180, 0), _rotationTime).
                           SetLoops(-1).
                           SetRelative(true);
        }
    }
    private void OnDestroy()
    {
        _tweener.Kill();
    }
}
