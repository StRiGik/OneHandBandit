using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Experimental.AI;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    private const int degreeToNextSection = 360 / 8;
    private int randOfDegreeToNextSection;
    private float randOfTimeRotation;
    [SerializeField] private Tweener tweener;
    [SerializeField] private GameObject obj;
    [SerializeField] private GameObject drumOne;
    [SerializeField] private GameObject drumTwo;
    [SerializeField] private GameObject drumThree;
    private Sequence seq;
    levelArm _lv;
    SceneController _sc;
    
    
    public void MethodOfRotationLevelArm()
    {
        seq = DOTween.Sequence();
        seq.Append(obj.transform.DORotate(new Vector3(50, 0, 0), 0.8f, RotateMode.LocalAxisAdd).SetEase(Ease.Linear));
        seq.Append(obj.transform.DORotate(new Vector3(-50, 0, 0), 0.2f, RotateMode.WorldAxisAdd).SetEase(Ease.Linear));
        seq.SetEase(Ease.Linear);
        seq.AppendCallback(RollDrums);
    }
    private void RollDrums()
    {
        randOfTimeRotation = Random.Range(3f, 10f);

        randOfDegreeToNextSection = Random.Range(1000, 5000);
        drumOne.transform.DORotate(new Vector3(randOfDegreeToNextSection * degreeToNextSection, 0, 0), randOfTimeRotation, RotateMode.WorldAxisAdd).SetEase(Ease.InOutQuart);

        randOfDegreeToNextSection = Random.Range(1000, 5000);
        drumTwo.transform.DORotate(new Vector3(randOfDegreeToNextSection * degreeToNextSection, 0, 0), randOfTimeRotation, RotateMode.WorldAxisAdd).SetEase(Ease.InOutQuart).SetDelay(0.2f);

        randOfDegreeToNextSection = Random.Range(1000, 5000);
        drumThree.transform.DORotate(new Vector3(randOfDegreeToNextSection * degreeToNextSection, 0, 0), randOfTimeRotation, RotateMode.WorldAxisAdd).SetEase(Ease.InOutQuart).SetDelay(0.4f);
        
        Debug.Log("HIIII!");

    }
}
