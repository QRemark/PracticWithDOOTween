using DG.Tweening;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private Vector3 _point;
    [SerializeField] private float _duration = 3f;
    [SerializeField] private int _repeats = -1;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        TravelToPoint();
    }

    private void TravelToPoint()
    {
        transform.DOMove(_point, _duration).SetLoops(_repeats, _loopType);
    }
}
