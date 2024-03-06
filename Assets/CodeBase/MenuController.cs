using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    [SerializeField] private GameObject _canvasMenu;
    [SerializeField] private GameObject _oneHandBandit;
    [SerializeField] private GameObject _backGround;
    [SerializeField] private GameObject _closeGameButton;
    [SerializeField] private OneHandBandit _gameControl;
    [SerializeField] private int _columOfDrums;

    public void StartGameButton()
    {
        _gameControl.OneHandBanditCreated(_columOfDrums);
        _canvasMenu.SetActive(false);
        _oneHandBandit.SetActive(true); 
        _backGround.SetActive(true);

    }

    public void CloseGame()
    {
        _gameControl.CloseGameAction();
        _canvasMenu.SetActive(true);
        _oneHandBandit.SetActive(false);
        _backGround.SetActive(false);

    }

    public void PlusDrum()
    {

    }
    public void MinusDrum()
    {

    }
}
