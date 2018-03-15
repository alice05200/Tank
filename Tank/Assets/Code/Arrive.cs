using UnityEngine;
using System.Collections;

public class Arrive : MonoBehaviour {
    public GameObject w1;
    public GameObject w2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider collider) {
        if (collider.gameObject.name == "Tank")
        {
            Instantiate(w1, transform.position, transform.rotation);
            Instantiate(w2, transform.position, transform.rotation);
            Debug.Log("Goal!");
            Application.LoadLevel("Exit");

        }
        
    }
}
