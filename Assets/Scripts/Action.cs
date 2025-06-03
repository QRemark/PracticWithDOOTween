using DG.Tweening;
using UnityEngine;

public abstract class Action : MonoBehaviour
{
    [SerializeField] protected float _duration = 3f;
    [SerializeField] protected int _repeats = -1;
    [SerializeField] protected LoopType _loopType = LoopType.Restart;

    protected virtual void Start()
    {
        Play();
    }

    protected abstract void Play();
}
