using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vectors : MonoBehaviour
{
    public Transform atf;
    public Transform btf;

    [Range(0f,4f)]

    public float offset = 1f;
    private void OnDrawGizmos()
    {
        Vector2 a = atf.transform.position;  // Stores the point in world
        Vector2 b = btf.transform.position; //  Stores the point in world
        Vector2 atob = b - a; // Displacement between points (Not Distance)
        Vector2 aToBDir = atob.normalized; // direction from a to b (a - b).Norm
        Gizmos.DrawLine(a, a + aToBDir * offset); // Creates a moving point along the direction
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
