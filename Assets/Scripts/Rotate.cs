using DG.Tweening;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private Vector3 _rotation;
    [SerializeField] private float _duration = 3f;
    [SerializeField] private int _repeats = -1;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        ChangeAxis();
    }

    private void ChangeAxis()
    {
        transform.DORotate(_rotation, _duration, RotateMode.FastBeyond360).SetLoops(_repeats, LoopType.Restart);
    }
}
