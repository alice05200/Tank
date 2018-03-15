using UnityEngine;
using System.Collections;

public class ChangeCamera : MonoBehaviour {

	// Use this for initialization
	void Start () {
        c2.enabled = true;
        c1.enabled = false;
        c3.enabled = false;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public Camera c1;
    public Camera c2;
    public Camera c3;
 
    void OnGUI () {
        
        if (GUI.RepeatButton(new Rect(0, Screen.height / 2 - 30, 30, 30), "W"))
        {
            c1.enabled = true;
            c2.enabled = false;
            c3.enabled = false;
        }
        if (GUI.RepeatButton(new Rect(0, Screen.height / 2, 30, 30), "C"))
        {
            c2.enabled = true;
            c1.enabled = false;
            c3.enabled = false;
        }
        if (GUI.RepeatButton(new Rect(0, Screen.height / 2 + 30, 30, 30), "F"))
        {
            c2.enabled = false;
            c1.enabled = false;
            c3.enabled = true;
        }
 
    }
}
