using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;

public class LevelArm : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject _SceneController;

    private Sequence _sequence;
    private bool _isActive = true;

    public delegate void MethodClick();
    public event MethodClick IsClickOnLevelArm;


    void Start()
    {
        this.IsClickOnLevelArm += _SceneController.GetComponent<OneHandBandit>().SpinReels;
    }
        
    public void ReadinessLevelArm()
    {
        _isActive = true;
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if (_isActive)
        {
            AnimateLeverPress();
            _isActive = false;
        }
    }

    public void AnimateLeverPress()
    {
        _sequence = DOTween.Sequence();
        _sequence.Append(this.transform.DORotate(new Vector3(70, 0, 0), 0.8f, RotateMode.WorldAxisAdd).SetEase(Ease.InQuart));
        _sequence.Append(this.transform.DORotate(new Vector3(-70, 0, 0), 0.2f, RotateMode.WorldAxisAdd).SetEase(Ease.OutBounce));
        _sequence.AppendCallback(Func1);

    }

    private void Func1()
    {
        Debug.Log("Запуск события!");
        IsClickOnLevelArm();
    }

}
