using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
     
    [SerializeField] private int _playerHealth = 150;
    [SerializeField] private int _damageValue;
    [SerializeField] private bool _playerDead = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckPlayerStatus();
        AttackPlayer();   
    }


private void AttackPlayer(){
    if(Input.GetKeyDown(KeyCode.Space))
    {
        Debug.Log("ATTACKING");
        _damageValue = Random.Range(0,60);
        if(_playerHealth > 0 && !_playerDead)
        {
            _playerHealth -= _damageValue;
            if(_playerHealth <= 0)
            {
                _playerHealth = 0;
            _playerDead = true;
            Debug.Log("Player is dead");
            }
        }

    }

}

private int PlayerHealthValue()
{
    return _playerHealth;
}

private bool CheckPlayerStatus()
{
  if(_playerHealth > 0)
  {
    return _playerDead = false;
  }
  else return _playerDead = true;
}

}
