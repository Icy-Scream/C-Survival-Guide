using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class JetPlaneController : MonoBehaviour
{
    [SerializeField] float _jetSpeed;
    [SerializeField] 
    private Vector3 _mousePos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       _mousePos = Input.mousePosition;
        transform.Translate((_mousePos-gameObject.transform.position).normalized * _jetSpeed * Time.deltaTime);
        float h = Input.GetAxis("Mouse X");
        float v = Input.GetAxis("Mouse Y");
        this.gameObject.transform.Translate(h, 0, v * _jetSpeed * Time.deltaTime);
    }
}
