using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Behaviour : MonoBehaviour
{
    private bool _playerIsMoving;
    [SerializeField] float _speed = 5f;
    [SerializeField] GameObject _dropLet;
     float _timer;
    [SerializeField] float _dropletSpawnSpeed = 0.5f;
    [SerializeField] List<GameObject> _dropletStorage = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        _timer = Time.time +_dropletSpawnSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
        DroppingDroplets();
        ClearDroplets();
    }

    private void PlayerMovement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * _speed * Time.deltaTime);
            _playerIsMoving = true;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * _speed * Time.deltaTime);
            _playerIsMoving = true;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * _speed * Time.deltaTime);
            _playerIsMoving = true;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * _speed * Time.deltaTime);
            _playerIsMoving = true;
        }
        else _playerIsMoving = false;

    }
    
    private void DroppingDroplets()
    {
        if (_playerIsMoving)
        {
            if(Time.time > _timer) 
            {
               var Drop = Instantiate(_dropLet, transform.position, Quaternion.identity);
                _dropletStorage.Add(Drop);
                _timer = Time.time + _dropletSpawnSpeed;
            }
            
        }
        else return;
    }

    private void ClearDroplets() 
    {
        if (Input.GetKeyDown(KeyCode.R)) 
        {
            foreach(var Droplet in _dropletStorage) 
            {
                Destroy(Droplet);
            }
            _dropletStorage.Clear();
        }
    }
}
