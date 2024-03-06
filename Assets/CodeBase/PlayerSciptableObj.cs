using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "NewProfile", menuName = "UsersProfiles", order = 51)]

public class PlayerSciptableObj : ScriptableObject
{
    [SerializeField] private string _login;
    [SerializeField] private string _password;
    [SerializeField] private int _balance;

    public PlayerSciptableObj(string login, string password) 
    {
        _login = login;
        _password = password;

    }
    public int GetBalance()
    {
        return _balance;
    }
    
}
