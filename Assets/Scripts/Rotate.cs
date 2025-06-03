using DG.Tweening;
using UnityEngine;

public class Rotate : Action
{
    [SerializeField] private Vector3 _rotation;
    [SerializeField] private RotateMode _rotateMode = RotateMode.FastBeyond360;

    protected override void Play()
    {
        transform.DORotate(_rotation, _duration, _rotateMode).SetLoops(_repeats, _loopType);
    }
}
