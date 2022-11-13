using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingTime : MonoBehaviour
{
    TextMesh _clockTimeText;
    int _timeHour;
    int _timeMinute;
    // Start is called before the first frame update
    void Start()
    {
        _clockTimeText = GetComponent<TextMesh>();
         
    }

    // Update is called once per frame
    void Update()
    {
        _timeHour = System.DateTime.Now.Hour;
        _timeMinute = System.DateTime.Now.Minute;
        _clockTimeText.text = (_timeHour.ToString() + ":" + _timeMinute.ToString());
    }
}
