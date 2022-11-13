using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string playerName;
    public int attackLevel;
    public int magicLevel;
    public int smithingLevel;
    public int miningLevel;
	[SerializeField] GameObject _spawn1;
	[SerializeField] GameObject _spawn2;
	[SerializeField] GameObject _spawn3;
	void Start ()
    {
		
	}

	void Update ()
    {
		spawnselection();
		if (Input.GetKey(KeyCode.A))
		{
			transform.Translate(Vector2.left * 8 * Time.deltaTime);
		}
		else if (Input.GetKey(KeyCode.D))
		{
			transform.Translate(Vector2.right * 8 * Time.deltaTime);
		}
	}

	private void spawnselection() 
	{
		if (Input.GetKeyDown(KeyCode.Alpha1)) 
		{
			this.gameObject.transform.position = _spawn1.transform.position;
		}
		else if (Input.GetKeyDown(KeyCode.Alpha2)) 
		{
			this.gameObject.transform.position = _spawn2.transform.position;
		}
		else if (Input.GetKeyDown(KeyCode.Alpha3)) 
		{
			this.gameObject.transform.position = _spawn3.transform.position;
		}
	}
	private void OnTriggerEnter(Collider collision)
	{
		if (collision.name == "Color_Change_Wall")
		{
			gameObject.GetComponent<Renderer>().material.color = new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f));
		}
		else { Debug.Log(collision.name); }
	}
}
