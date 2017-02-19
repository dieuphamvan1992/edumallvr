using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideShowController : MonoBehaviour
{

    public string[] slides;

    private int slide_index = 0;

    void Start()
    {
        if (slides.Length > 0 && false)
        {
            GetComponent<Renderer>().material.mainTexture = (Texture2D)Resources.Load(slides[0]);
            slide_index++;
        }
    }

    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.DpadDown) || Input.GetKey(KeyCode.RightArrow))
        {
            if (slide_index < slides.Length)
            {
                GetComponent<Renderer>().material.mainTexture = (Texture2D)Resources.Load(slides[slide_index]);
                slide_index += 1;
            }
            
        }
    }
}