using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public static class UtilityHelper
{
    public static void ChangeObjectColor(GameObject obj, Color color, bool randomColor = false)
    {
        if (randomColor) 
        { 
           color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f,1f));
        }
        obj.GetComponent<MeshRenderer>().material.color = color;
      
    }
}
