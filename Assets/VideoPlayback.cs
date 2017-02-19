using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

#if (MOBILE_PLATFORM)
public class MovieTexture : Texture
{
    // Constructors
    public MovieTexture ();
   
    // Methods
    public void Play ();
    public void Stop ();
    public void Pause ();
   
    // Properties
    public AudioClip audioClip { get; }
    public bool loop { get; set; }
    public bool isPlaying { get; }
    public bool isReadyToPlay { get; }
}
#endif

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
