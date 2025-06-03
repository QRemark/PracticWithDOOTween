using DG.Tweening;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private Renderer _targetRenderer;
    [SerializeField] private float _duration = 2f;
    [SerializeField] private Color[] _colors;

    private int _currentIndex = 0;

    private void Start()
    {
        ChangeToNextColor();
    }

    private void ChangeToNextColor()
    {
        Color nextColor = _colors[_currentIndex];
        _currentIndex = ++_currentIndex % _colors.Length;

        _targetRenderer.material.DOColor(nextColor, _duration).OnComplete(ChangeToNextColor);
    }
}
