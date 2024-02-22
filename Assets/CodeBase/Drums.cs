using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEditor.Build.Content;

public class Drums : MonoBehaviour
{
    private int _angleOfRotation;
    private int _edgeRotationAngel = 360/10;
    private float _delay;
    private int _randOfTimeRotation;


    public void SpinTheReel()
    {
        this.transform.DORotate(new Vector3(_angleOfRotation * _edgeRotationAngel, 0, 0), _randOfTimeRotation,RotateMode.WorldAxisAdd)
            .SetEase(Ease.InOutQuart)
            .SetDelay(_delay);    
    }
}
