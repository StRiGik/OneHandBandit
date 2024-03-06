using DG.Tweening;
using System.Collections.Generic;
using UnityEngine;

public class OneHandBandit : MonoBehaviour
{
    [SerializeField] private GameObject _levelArm;
    [SerializeField] private GameObject _drumSet;
    [SerializeField]private List<Drums> _drumList;

    enum states { aaa, sss, zzz }
    public void OneHandBanditCreated(int countOfDrums)
    {
        _drumList = new List<Drums>();
        float distanceToNextDrum = -0.8f;
        for(int i = 0; i < countOfDrums; i++)
        {
            var drum = Instantiate(_drumSet, new Vector3(distanceToNextDrum, 6, 0), Quaternion.Euler(0, -90, 0)).GetComponent<Drums>();
            distanceToNextDrum += 0.6f;
            _drumList.Add(drum);
            Debug.Log("Добавлен новый барабан!");
        }
        _drumList.Reverse();
    }

    public void SpinReels()
    {
        Debug.Log("Запуск вращения!!!");
        float delay = 0;
        for(int i = 0; i < _drumList.Count; i++)
        {
            int angleOfRotation = Random.Range(1000, 5000);
            int rotationTime = Random.Range(5, 10);
            _drumList[i].SpinTheReel(angleOfRotation, rotationTime, delay);
            delay += 0.2f;
        }
    }
    public void CloseGameAction()
    {
        for (int i = 0; i < _drumList.Count; ++i)
        {
            Destroy(_drumList[i].gameObject);

        }
        _drumList.Clear();
    }

}

