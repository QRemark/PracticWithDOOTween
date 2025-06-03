using DG.Tweening;
using UnityEngine;

public class Scale : Action
{
    [SerializeField] private Vector3 _targetScale;

    protected override void Play()
    {
        transform.DOScale(_targetScale, _duration).SetLoops(_repeats, _loopType);
    }
}