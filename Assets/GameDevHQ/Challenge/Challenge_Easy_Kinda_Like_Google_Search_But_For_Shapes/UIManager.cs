using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class UIManager : MonoBehaviour
{
    [SerializeField] TMP_InputField _InputField;
    public string _userInput { get; private set; }
    public bool _spawn { get; private set; }
   
    private void Start()
    {
        _InputField.GetComponent<TMP_InputField>();
    }

    public void SpawnButton() 
    {
        _userInput = _InputField.text;
         StartCoroutine(DespawnRoutine());
    }



    public void ClearButton() 
    { 
        _InputField.text = string.Empty;
        _userInput = string.Empty;
        _spawn = false;
    }
    IEnumerator DespawnRoutine() 
    {
        _spawn = false;
        yield return new WaitForSeconds(0.1f);
        _spawn = true;
    }
    
}
