using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
   [SerializeField] private Camera _camera;
    RaycastHit hit;
    Color _originalColor;
    GameObject current;
    GameObject newObj;

    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {

            Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out hit)) 
            {
                if(current == null) 
                { 
                    current = hit.transform.gameObject;
                    _originalColor = current.transform.GetComponent<MeshRenderer>().material.color;
                    current.transform.GetComponent<MeshRenderer>().material.color = Color.red;

                }
                else 
                {   newObj = hit.transform.gameObject;
                    current.transform.GetComponent<MeshRenderer>().material.color = _originalColor;
                     _originalColor = newObj.transform.GetComponent<MeshRenderer>().material.color;
                     newObj.transform.GetComponent<MeshRenderer>().material.color = Color.red;
                    current = newObj;
                }    
            }
        } 
    }
}
