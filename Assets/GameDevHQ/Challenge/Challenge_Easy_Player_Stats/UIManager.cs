using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] Text _playerText;
    [SerializeField] Text _attackText;
    [SerializeField] Text _magicText;
    [SerializeField] Text _smithingText;
    [SerializeField] Text _miningText;
    [SerializeField] GameObject _player;
    Player _playerScript;
    // Start is called before the first frame update
    void Start()
    {
        _playerScript = _player.GetComponent<Player>();
        if (_playerScript == null) 
        {
            Debug.Log("player missing");
        }
        _playerText.text = _playerScript.playerName.ToString();
        _attackText.text = _playerScript.attackLevel.ToString();
        _magicText.text = _playerScript.magicLevel.ToString();
        _miningText.text = _playerScript.miningLevel.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
