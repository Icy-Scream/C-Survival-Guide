using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_Practice : MonoBehaviour
{
   [SerializeField] private int  _playerSpeed;
   [SerializeField] private int  _playerAccerlate;
   [SerializeField] private int  _playerDeaccerlate;
   [SerializeField] private bool hasZeroVelocity;
   [SerializeField] private int points;
   [SerializeField] private int apples;

   [SerializeField] private int MAXSPEED;
    void Start()
    {
        
        hasZeroVelocity = false;
        StartCoroutine(AddApplesRoutine());
        StartCoroutine(ReachingMaxSpeed());
       // UltimatePrintOut();
        MAXSPEED = Random.Range(60,120);
    }

    // Update is called once per frame
    void Update()
    {
        //playerInputs();
       // switchingPoints();
       // playerSpeed();
       
    }

  private void playerSpeed(){
     if(_playerSpeed >= 20)
        {
            print("SLOW DOWN");
        }
        else if(_playerSpeed <= 0)
        {   
            _playerSpeed = 0;
            hasZeroVelocity = true;
            print("YOU NEED TO SPEED UP");
        }
        else{hasZeroVelocity = false;}
    }

  private void playerInputs(){
    if(Input.GetKeyDown(KeyCode.S))
        {
          _playerSpeed += _playerAccerlate;
          print(_playerSpeed);
        }
        else if(Input.GetKeyDown(KeyCode.A) && !hasZeroVelocity)
        {
            
            _playerSpeed -= _playerDeaccerlate;
            
        }

    if(Input.GetKeyDown(KeyCode.Q)){
        points = 50;
    }

    else if(Input.GetKeyDown(KeyCode.W)){
        points = 100;
    }
    else if(Input.GetKeyDown(KeyCode.E)){
        points = 0;
    }

   } 

  private void switchingPoints(){
    switch(points)
    {

    case 50:
    Debug.Log("POINTS ARE 50");
    break;
    case 100:
    Debug.Log("Points ARE 100");
    break;
    default:
    Debug.Log("YOU NEED POINTS FOR A MESSGAE");
    break;

    
    }
   }

//COROUTINE PRAC
IEnumerator AddApplesRoutine()
{
    for(int i=0;i<100;i++)
    {
        apples++;
        yield return new WaitForSeconds(0.5f);
    }
}
        
private void UltimatePrintOut()
{
    for(int i=0; i <=10; i++)
    {
        Debug.Log("Print to 10 " + i);      
    }

    for(int i=0; i <20; i++)
    {
        if(i%2 == 0){
        Debug.Log("EVEN NUMBER " + i);      
        }

    }

    for(int i=0; i <=30; i++)
    {
        if(i%2 != 0){
        Debug.Log("ODD NUMBER " + i);      
        }

    }
}        
IEnumerator ReachingMaxSpeed()
{
    while(_playerSpeed <= MAXSPEED){
        _playerSpeed+=5;
        if(_playerSpeed > MAXSPEED){
            _playerSpeed = MAXSPEED;
        }
        yield return new WaitForSeconds(0.5f);
    }
}

        






}
