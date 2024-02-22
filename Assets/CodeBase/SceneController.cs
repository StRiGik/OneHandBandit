using DG.Tweening;
using System.Collections.Generic;
using UnityEngine;


public class SceneController : MonoBehaviour
{
    [SerializeField] private List<GameObject> drumList;

    private Sequence seq;
    private const int degreeToNextSection = 360 / 10;
    private int randOfDegreeToNextSection;
    private float randOfTimeRotation;


    
    private void RollDrums(int randomTimeForRotation, int[] degreeToRotate)
    {
        float delay = 0;
        for(int i = 0; i < drumList.Count; i++)
        {
            drumList[i].transform.DORotate(new Vector3(degreeToRotate[i] * degreeToNextSection, 0, 0), randomTimeForRotation, RotateMode.WorldAxisAdd).SetEase(Ease.InOutQuart).SetDelay(delay);
            delay += 0.2f;
        }
    }

    /*private void RollDrums()
    {
        randOfTimeRotation = Random.Range(3f, 10f);

        randOfDegreeToNextSection = Random.Range(1000, 5000);
        drumOne.transform.DORotate(new Vector3(randOfDegreeToNextSection * degreeToNextSection, 0, 0), randOfTimeRotation, RotateMode.WorldAxisAdd).SetEase(Ease.InOutQuart);

        randOfDegreeToNextSection = Random.Range(1000, 5000);
        drumTwo.transform.DORotate(new Vector3(randOfDegreeToNextSection * degreeToNextSection, 0, 0), randOfTimeRotation, RotateMode.WorldAxisAdd).SetEase(Ease.InOutQuart).SetDelay(0.2f);

        randOfDegreeToNextSection = Random.Range(1000, 5000);
        drumThree.transform.DORotate(new Vector3(randOfDegreeToNextSection * degreeToNextSection, 0, 0), randOfTimeRotation, RotateMode.WorldAxisAdd).SetEase(Ease.InOutQuart).SetDelay(0.4f);

        randOfDegreeToNextSection = Random.Range(1000, 5000);
        drumFour.transform.DORotate(new Vector3(randOfDegreeToNextSection * degreeToNextSection, 0, 0), randOfTimeRotation, RotateMode.WorldAxisAdd).SetEase(Ease.InOutQuart).SetDelay(0.6f);
    }*/
}
