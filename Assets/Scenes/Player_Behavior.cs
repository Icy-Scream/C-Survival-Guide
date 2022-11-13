using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Behavior : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            UtilityHelper.ChangeObjectColor(this.gameObject,Color.white,true);
        }
    }
}
