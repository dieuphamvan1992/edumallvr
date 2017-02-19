using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VrPlayerController : OVRPlayerController
{
    public Text info;

    /// <summary>
	/// Invoked by OVRCameraRig's UpdatedAnchors callback. Allows the Hmd rotation to update the facing direction of the player.
	/// </summary>
	public void UpdateTransform(OVRCameraRig rig)
    {
        Transform root = CameraRig.trackingSpace;
        Transform centerEye = CameraRig.centerEyeAnchor;

        if (HmdRotatesY)
        {
            Vector3 prevPos = root.position;
            Quaternion prevRot = root.rotation;

            transform.rotation = Quaternion.Euler(0.0f, centerEye.rotation.eulerAngles.y, 0.0f);

            root.position = prevPos;
            root.rotation = prevRot;
        }

        UpdateController();
        LogTouchPad();
    }

    void LogTouchPad()
    {
        string str = "";
        if (OVRInput.Get(OVRInput.Button.DpadUp))
        {
            str = " " + "Up";
        }

        if (OVRInput.Get(OVRInput.Button.DpadDown))
        {
            str = " " + "Down";
        }

        if (OVRInput.Get(OVRInput.Button.DpadLeft))
        {
            str = " " + "Left";
        }

        if (OVRInput.Get(OVRInput.Button.DpadRight))
        {
            str = " " + "Right";
        }

        if (OVRInput.Get(OVRInput.Button.One))
        {
            str = " " + "One";
        }
    }

    void SetInfoText(string str)
    {
        info.text = str;
    }
}
