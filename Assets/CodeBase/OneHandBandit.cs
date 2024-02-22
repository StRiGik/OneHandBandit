using System.Collections.Generic;
using UnityEngine;

public class OneHandBandit : MonoBehaviour
{
    [SerializeField] private Drums _drum;
    [SerializeField] private GameObject _levelArm;
    [SerializeField] private GameObject _drumsSet;
    [SerializeField]private int _requiredNumberOfReels;
    [SerializeField]private List<Drums> _drumList;


    private void Start()
    {
        float distanceToNextDrum = -0.8f;
        for(int i = 0; i < _requiredNumberOfReels; i++)
        {
            Instantiate(_drum, new Vector3(distanceToNextDrum, 6, 0), Quaternion.Euler(0, -90, 0));
            distanceToNextDrum += 0.6f;
            _drumList.Add(_drum);

        }
    }
}
