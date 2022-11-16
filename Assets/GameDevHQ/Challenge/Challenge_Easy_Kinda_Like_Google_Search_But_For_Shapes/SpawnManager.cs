using System.Collections;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] UIManager InputField;
     GameObject[] _primitiveObjects = new GameObject[4];
    public enum PrimitiveObject
    {
        cube,
        sphere,
        capsule,
        cylinder
    }
    void Start()
    {
        for (int i = 0; i < _primitiveObjects.Length; i++)
        {
            var SpawnObject = GameObject.Find("Primitive Shapes").transform.GetChild(i).gameObject;
            _primitiveObjects[i] = SpawnObject;
            _primitiveObjects[i].SetActive(false);
        }

    }

    void Update()
    {
        SpawningGamobjects(InputField._spawn, InputField._userInput);
    }

    private void SpawningGamobjects(bool spawn, string obj)
    {
        if (obj == null) { return; }
        string objectlowercase = obj.ToLower();
          if (spawn)
           {
               if (objectlowercase == "cube")
               {
                   _primitiveObjects[(int)PrimitiveObject.cube].SetActive(true);
                   _primitiveObjects[(int)PrimitiveObject.cube].transform.position = new Vector3(0, 0, 0);
               }
               else if (objectlowercase == "sphere") {
                _primitiveObjects[(int)PrimitiveObject.sphere].SetActive(true);
                _primitiveObjects[(int)PrimitiveObject.sphere].transform.position = new Vector3(0, 0, 0);
               }
               else if (objectlowercase == "capsule")
               {
                _primitiveObjects[(int)PrimitiveObject.capsule].SetActive(true);
                _primitiveObjects[(int)PrimitiveObject.capsule].transform.position = new Vector3(0, 0, 0);
               }
               else if (objectlowercase == "cylinder")
               {
                _primitiveObjects[(int)PrimitiveObject.cylinder].SetActive(true);
                _primitiveObjects[(int)PrimitiveObject.cylinder].transform.position = new Vector3(0, 0, 0);
               }
               else { Debug.Log("ITEM NOT EXIST"); }
           }
           else if (!spawn)
           {
               foreach (var o in _primitiveObjects) 
               { 
                   o.SetActive(false);
               }
           }
    }
}



      




