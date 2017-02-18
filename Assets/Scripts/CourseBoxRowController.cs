using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CourseBoxRowController : MonoBehaviour {

    public GameObject courseBox ;
    public float gridx = 5f;
    public float spacing = 20f;

    // Use this for initialization
    void Start () {
        float y = transform.position.y;
        float z = transform.position.z;

        for (int x = 0; x < gridx; x++)
        {            
            Vector3 pos = new Vector3(x * spacing, y, z);
            Transform coursesTranform = gameObject.transform.parent.parent;
            GameObject coursesObject = coursesTranform.gameObject;
            CoursesContainerController coursesController = coursesObject.GetComponent<CoursesContainerController>();


            GameObject clone = (GameObject)Instantiate(courseBox, pos, Quaternion.identity);
            clone.transform.parent = transform;

            if (coursesController.texs.Length > 0)
            {
                int index = CoursesContainerController.texIndex % coursesController.texs.Length;

                clone.GetComponent<Renderer>().material.mainTexture = coursesController.texs[index];
                CoursesContainerController.texIndex += 1;
            }
        }
    }
	


	// Update is called once per frame
	void Update () {
    }

    void createTex(string url)
    {
        //if (coursesController.texs[index] == null)
        //{
        //    Texture2D tex = new Texture2D(4, 4, TextureFormat.DXT1, false);
        //    WWW www = new WWW(coursesController.courses[index].image_url);
        //    yield return www;
        //    www.LoadImageIntoTexture(tex);

        //    coursesController.texs[index] = tex;
        //}
    }
}
