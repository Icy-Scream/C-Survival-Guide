using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
     
    [SerializeField] private int _playerHealth = 150;
    [SerializeField] private int _damageValue;
    [SerializeField] private bool _playerDead = false;

    [SerializeField] private Vector3[] _SpawnPos;

    [SerializeField] private int _numberofSpawns;

    [SerializeField] private bool _playerSpawn = false;

    // Start is called before the first frame update
    void Start()
    {
        _SpawnPos = new Vector3[5];
    }

    // Update is called once per frame
    void Update()
    {
       
        GenerateRandomSpawns();
        GetRandomSpawn();
        PlayerSpawnPOS();
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

private void GenerateRandomSpawns()
{
 if(Input.GetKeyDown(KeyCode.Q))
    {
          _numberofSpawns = _SpawnPos.Length;
          for(int i = 0; i <= _numberofSpawns; i++)
          {
           _SpawnPos[i].Set(Random.value, Random.value,Random.value);  
          } 
    }

    
   else if(!_playerSpawn)
   {
    gameObject.transform.position = new Vector3(Random.value,Random.value,Random.value);
    _playerSpawn = true;
   } 
}
    

    

private Vector3 GetRandomSpawn()
{
    int random = Random.Range(0,_numberofSpawns);
    return _SpawnPos[random];
}

private void PlayerSpawnPOS()
{
 if(Input.GetKeyDown(KeyCode.W))
 {
    gameObject.transform.position = GetRandomSpawn();
 }
}

}
