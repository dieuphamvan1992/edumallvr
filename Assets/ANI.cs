using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ANI : MonoBehaviour {

	public GameObject _model;
	private Animator _ani;
	// Use this for initialization
	void Start () {
		_ani = _model.GetComponent<Animator> ();
		//_ani.SetBool ("Squat",true);
		_ani.SetFloat ("Speed", 0.33f);
		//_ani.SetFloat ("Speed", 0.33f);
		_ani.SetFloat ("Speed", 0.66f);

	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
