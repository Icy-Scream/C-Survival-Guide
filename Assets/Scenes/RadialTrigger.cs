using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEditor.EditorTools;
using UnityEngine;
using UnityEngine.Rendering;

public class RadialTrigger : MonoBehaviour
{
    public Transform objtf;
    [Range(0f, 4f)]
    Vector2 objpos;
    Vector2 origin;
    void Update()
    {
        objpos = objtf.transform.position;
        origin = this.transform.position;
       Vector2 localspace = objpos - origin;
       float _playerPOS = Vector2.Dot(Vector2.down,localspace.normalized);
        Debug.Log(_playerPOS);
        if (Vector3.Dot(origin,objpos) < 0)
            {
                print("The other transform is behind me!");
            }
        
    }
}
