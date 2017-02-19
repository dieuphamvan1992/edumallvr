using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
public class AudioScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
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
        
        yield return new WaitForSeconds(31);
        EditorSceneManager.LoadScene("Edumall");
        //cube.transform.eulerAngles += new Vector3(0, 0, 90);
    }
}
