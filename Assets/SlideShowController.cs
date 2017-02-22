using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SlideShowController : MonoBehaviour
{

    public static string[] slideImages = {
          "slide1",
          "slide2",
          "slide3",
          "slide4",
          "slide5",
          "slide6",
          "slideq1",
          "slideq2",
          "slideend1",
          "slideend2",
          "slideendend"
    };

    private int slide_index = 0;

    void Start()
    {
        Debug.Log(slideImages.Length);
        if (slideImages.Length > 0)
        {
            gameObject.GetComponent<Renderer>().material.mainTexture = (Texture2D)Resources.Load("slide1");
            slide_index++;
        }
    }

    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.DpadDown) || Input.GetKey(KeyCode.RightArrow))
        {
            if (slide_index < slideImages.Length)
            {
                gameObject.GetComponent<Renderer>().material.mainTexture = (Texture2D)Resources.Load(slideImages[slide_index]);
                slide_index += 1;
            }

            if (slide_index == slideImages.Length)
            {
                //SceneManager.LoadScene("Edumall");
                StartCoroutine(Rotehole());
            }
            
        }
    }

    IEnumerator Rotehole()
    {
        //yield return new WaitForSeconds(2);
        //cube.transform.eulerAngles += new Vector3(0, 0, 90);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Edumall");
        //cube.transform.eulerAngles += new Vector3(0, 0, 90);
    }
}