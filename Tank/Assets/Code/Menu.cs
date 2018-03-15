using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {
    public Canvas b1;
    public Canvas b2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI() {
        if (Input.GetMouseButtonDown(0))
        {
            Application.LoadLevel("1");
        }
        if (Input.GetKey(KeyCode.Escape)) {
            Application.Quit();
        }
    }
    
}
