using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoPlayback : MonoBehaviour {
    public GameObject Sphere;
	// Use this for initialization
	void Start () {
        MovieTexture video360 = (MovieTexture)Sphere.GetComponent<Renderer>().material.mainTexture;
        video360.loop = true;
        video360.Play();		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
