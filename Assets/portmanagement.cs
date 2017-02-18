using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portmanagement : MonoBehaviour {
    private float ypos = 250;
    private float endposz = -28;
    private float moverate = 1f;
 	void Start () {
        //ypos = this.gameObject.transform.position.x;
        //Debug.Log(ypos.ToString());
	}
	
	// Update is called once per frame
	void Update () {        
        if (this.gameObject.transform.position.z <endposz)
        {
            this.gameObject.transform.position += new Vector3(0, 0, moverate);
            //this.gameObject.transform.eulerAngles += new Vector3(0,0,15);            
        }
	}
}
