using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;

public class LevelArm : MonoBehaviour, IPointerClickHandler
{
    private Sequence _sequence;
    [SerializeField] private GameObject _SceneController;

    void Start()
    {
        this.IsClickOnLevelArm += _SceneController.GetComponent<OneHandBandit>().SpinReels;
    }

    public delegate void MethodClick();
    public event MethodClick IsClickOnLevelArm;
    
    public void OnPointerClick(PointerEventData eventData)
    {
        AnimateLeverPress();
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
