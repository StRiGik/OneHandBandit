using UnityEngine;
using UnityEngine.EventSystems;

public class levelArm : MonoBehaviour, IPointerClickHandler
{
    public delegate void MethodClick();
    public event MethodClick IsClickOnLevelArm;
    [SerializeField]private SceneController _sc;


    void Start()
    {
        IsClickOnLevelArm += _sc.MethodOfRotationLevelArm;
    }

    private bool isClickable = true;
    public void OnPointerClick(PointerEventData eventData)
    {
        if (isClickable)
            IsClickOnLevelArm();
        else
        {
            Debug.Log("подождите конца раунда");
        }
        
    }
}
