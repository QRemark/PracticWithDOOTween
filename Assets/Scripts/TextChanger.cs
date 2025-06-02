using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;

    private string _secondLine = "Забудь про учебу смелее, ";
    private string _thirdLine = "Но приходиться думать ";
    private string _fourthLine = "Всем детям на свете, как их провести веселее ";

    private float _shortDuration = 1.5f;
    private float _longDuration = 6f;

    private void Start()
    {
        WriteNextText();
    }

    private void WriteNextText()
    {
        Sequence sequence = DOTween.Sequence();
        
        sequence.AppendInterval(_shortDuration);
        sequence.Append(_text.DOText(_secondLine, _longDuration));
        sequence.Append(_text.DOText(_thirdLine, _longDuration).SetRelative());
        sequence.Append(_text.DOText(_fourthLine, _longDuration, true, ScrambleMode.All));
    }
}
