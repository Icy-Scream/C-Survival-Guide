using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoRoutine : MonoBehaviour
{
    public bool _hide =false;
    private WaitForSeconds _changeColorWait = new WaitForSeconds(3.0f);
    private MeshRenderer _render;
    // Start is called before the first frame update
    void Start()
    {
        _render = GetComponent<MeshRenderer>();
         StartCoroutine(ColorChangeRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.I) && !_hide)
        {
            StartCoroutine(MagicTrick());
        }
    }

    IEnumerator MagicTrick()
    {
     _render.enabled = false;
    _hide = true;
     yield return new WaitForSeconds(5f);
     _render.enabled = true;
    _hide = false;
    }

    IEnumerator ColorChangeRoutine()
    {
        while(true)
        {
         yield return _changeColorWait;
        _render.material.color = new Color(Random.value,Random.value,Random.value);
        }

    }
}
