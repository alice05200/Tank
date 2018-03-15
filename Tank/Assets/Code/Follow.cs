using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour {
    public Transform obj1;
    public Camera c1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 distance = (c1.transform.position - obj1.transform.position);
        float originY = c1.transform.position.y;
        Vector3 newPosition = obj1.transform.position + distance.normalized * 3;
        newPosition.y = originY;
        c1.transform.position = newPosition;
        
	}
}
