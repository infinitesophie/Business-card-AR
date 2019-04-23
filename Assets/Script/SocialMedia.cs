using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocialMedia : MonoBehaviour
{
    // Start is called before the first frame update
    public void OpenFacebook()
    {

        Application.OpenURL("https://www.facebook.com/sophie.me.0");
    }
    public void OpenLinkdIn()
    {
        Application.OpenURL("https://www.linkedin.com/in/sophiamary/");
    }
}
