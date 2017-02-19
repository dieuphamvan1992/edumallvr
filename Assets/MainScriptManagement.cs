using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScriptManagement : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //audio.Play(44100);		
        StartCoroutine(PlayIntro());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    IEnumerator PlayIntro()
    {
        //yield return new WaitForSeconds(2);
        //cube.transform.eulerAngles += new Vector3(0, 0, 90);
        yield return new WaitForSeconds(2);
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Edumall");
        //cube.transform.eulerAngles += new Vector3(0, 0, 90);
    }
}
