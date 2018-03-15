using UnityEngine;
using System.Collections;

public class Explode : MonoBehaviour {
    public GameObject obj1;
    public GameObject explosion;
    public GameObject e2;
    public GameObject e3;
    public GameObject e4;
    public GameObject e5;
    public GameObject e6;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnCollisionEnter(Collision collision) {
        Instantiate(explosion, transform.position, transform.rotation);
        Instantiate(e2, transform.position, transform.rotation);
        Instantiate(e3, transform.position, transform.rotation);
        Instantiate(e4, transform.position, transform.rotation);
        Instantiate(e5, transform.position, transform.rotation);
        Instantiate(e6, transform.position, transform.rotation);
        Destroy(obj1);
        
        
    }
    

}
