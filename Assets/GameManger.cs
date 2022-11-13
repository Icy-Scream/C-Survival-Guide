using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    public float Speed { get; private set; }
    public string Name { get; set; }

    private string _name;
    void Start()
    {
        Speed = 10f;
        Debug.Log(Speed);
        Name = "JOSHUA";
        Debug.Log(Name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
