using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    [SerializeField] private List<string> _names = new List<string>();
    void Start()
    {
        foreach(var name in _names) 
        { 
            Debug.Log(name);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int _removeName = Random.Range(0, _names.Count);
            _names.RemoveAt(_removeName);
            foreach(var name in _names) { Debug.Log(name);}
        }
    }
}
