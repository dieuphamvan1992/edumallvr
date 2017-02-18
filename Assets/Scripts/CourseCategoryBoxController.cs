using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CourseCategoryBoxController : MonoBehaviour {

    public GameObject courseBoxRow;
    public float gridZ = 5f;
    public float spacing = 20f;

    // Use this for initialization
    void Start () {
        float x = transform.position.x;
        float y = transform.position.y;

        for (int z = 0; z < gridZ; z++)
        {
            Vector3 pos = new Vector3(x, y, z * spacing);
            GameObject clone = (GameObject)Instantiate(courseBoxRow, pos, Quaternion.identity);
            clone.transform.parent = transform;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    
}
