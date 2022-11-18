using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PictureGenerator : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _pictures;
  [SerializeField] private GameObject _currentPicture;
  [SerializeField]  private int _index;
    bool _cyclePictures = true;
    // Start is called before the first frame update
    void Start()
    {
        _index = Random.Range(0, _pictures.Length);
        _currentPicture = Instantiate(_pictures[_index], new Vector3(0, 2, -2.8f), Quaternion.Euler(0f, 180f, 0f));
        _currentPicture.transform.parent = gameObject.transform;
        StartCoroutine(RotatePicturesRoutine());

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator RotatePicturesRoutine() 
    {
        while (_cyclePictures)
        { 
            yield return new WaitForSeconds(5f);
            Destroy(_currentPicture);
            if(_index >= _pictures.Length - 1) 
            {  _index = 0;
               _currentPicture = Instantiate(_pictures[_index],new Vector3(0,2,-2.8f), Quaternion.Euler(0f, -180f, 0f));
               _currentPicture.transform.parent = gameObject.transform;
               _index++;
            }

            else 
            {
                _index++;
                _currentPicture = Instantiate(_pictures[_index], new Vector3(0, 2,-2.8f), Quaternion.Euler(0f, -180f, 0f));
                _currentPicture.transform.parent = gameObject.transform;
            }
        }
    }
}

        
        
        
