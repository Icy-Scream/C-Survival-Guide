using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutine : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(NameRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator NameRoutine()
    {
        yield return new WaitForSeconds(3);
        Debug.Log("JOSHUA");
    }
}
