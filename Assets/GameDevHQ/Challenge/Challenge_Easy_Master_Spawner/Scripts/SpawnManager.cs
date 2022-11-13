using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] objectsToSpawn;
    [SerializeField] private bool _spawn;
    private void Start()
    {
        StartCoroutine(RandomSpawnObjects());
    }

    IEnumerator RandomSpawnObjects()
    {
        while (_spawn) 
        { 
         yield return new WaitForSeconds(2f);
         Instantiate(objectsToSpawn[Random.Range(0, 4)], transform.position, Quaternion.identity);
        }
    }

}
