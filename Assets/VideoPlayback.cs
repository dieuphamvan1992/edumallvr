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
    IEnumerator Start()
    {
        MovieTexture video360 = (MovieTexture)Sphere.GetComponent<Renderer>().material.mainTexture;
        video360.Play();
        yield return new WaitForSeconds(45);
        video360.Pause();
        if (!video360.isPlaying)
        {
            SceneManager.LoadScene("Edumall");
        }
    }

    void Update()
    {
        //Debug.Log("asdasdas");
    }
}
