using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    [SerializeField] private GameObject[] _gameObjects = new GameObject[3];
    [SerializeField] private List<GameObject> _objectsSpawned = new List<GameObject>();
    private Vector3 _randomPos;
    [SerializeField] private int SpawnCount;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        { 
            _randomPos = new Vector2(Random.Range(-9f, 9f), Random.Range(-9f, 9f));
            SpawnCount++;
            
            if(SpawnCount <= 10) 
            { 
                 var _newlySpawned = Instantiate(_gameObjects[Random.Range(0, _gameObjects.Length)], _randomPos, Quaternion.identity) as GameObject;
                _objectsSpawned.Add(_newlySpawned);
            }
            else 
            { 
                foreach(var obj in _objectsSpawned) 
                {
                    obj.GetComponent<MeshRenderer>().material.color = Color.green;
                }
                _objectsSpawned.Clear();
                SpawnCount = 0;
            }
            
        }

    }
}
