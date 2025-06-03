using DG.Tweening;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private Vector3 _rotation;
    [SerializeField] private float _duration = 3f;
    [SerializeField] private int _repeats = -1;
    [SerializeField] private LoopType _loopType;
    [SerializeField] private RotateMode _rotateMode = RotateMode.FastBeyond360;

    private void Start()
    {
        ChangeAxis();
    }

    private void ChangeAxis()
    {
        transform.DORotate(_rotation, _duration, _rotateMode).SetLoops(_repeats, _loopType);
    }
}
