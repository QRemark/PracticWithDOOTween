using DG.Tweening;
using UnityEngine;

public class Move : Action
{
    [SerializeField] private Vector3 _targetPosition;
    
    protected override void Play()
    {
        transform.DOMove(_targetPosition, _duration).SetLoops(_repeats, _loopType);
    }
}