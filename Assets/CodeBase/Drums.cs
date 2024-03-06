using UnityEngine;
using DG.Tweening;


public class Drums : MonoBehaviour
{


    private int _rotatioAngleToNextplane = 360 / 10;

    public void SpinTheReel(int angleOfRotation, int rotationTime, float delay)
    {
        Debug.Log("начинаю вращать отдельный барабан!");
        DOTween.Sequence().
        Append(this.transform.DORotate(new Vector3(angleOfRotation * _rotatioAngleToNextplane, 0, 0), rotationTime, RotateMode.WorldAxisAdd)
        .SetEase(Ease.InOutQuart).SetDelay(delay));
        
    }
    
}
