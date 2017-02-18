﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class portmanagement : MonoBehaviour {
    //private float ypos = 250;
    private float endposz = -30;
    private float moverate = 0.3f;
    public GameObject cube;
 	void Start () {
        //ypos = this.gameObject.transform.position.x;
        //Debug.Log(ypos.ToString());
	}
	
	// Update is called once per frame
	void Update () {
        if (this.gameObject.transform.position.z < endposz)
        {
            this.gameObject.transform.position += new Vector3(0, 0, moverate);
            //this.gameObject.transform.eulerAngles += new Vector3(0,0,15);            
        }
        else
        {
            //this.gameObject.transform.eulerAngles += new Vector3(0, 0, 15);
            StartCoroutine(Rotehole());
        }
	}

    IEnumerator Rotehole()
    {
        //yield return new WaitForSeconds(2);
        //cube.transform.eulerAngles += new Vector3(0, 0, 90);
        yield return new WaitForSeconds(2);
        EditorSceneManager.LoadScene("Edumall");
        //cube.transform.eulerAngles += new Vector3(0, 0, 90);
    }
}
