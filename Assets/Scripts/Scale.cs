using DG.Tweening;
using UnityEngine;

public class Scale : MonoBehaviour
{
    [SerializeField] private Vector3 _targetScale;
    [SerializeField] private float _duration = 4f;
    [SerializeField] private int _repeats = -1;
    [SerializeField] private LoopType _loopType;


    private void Start()
    {
        ChangeSize();
    }

    private void ChangeSize()
    {
        transform.DOScale(_targetScale, _duration).SetLoops(_repeats, LoopType.Yoyo);
    }
}
