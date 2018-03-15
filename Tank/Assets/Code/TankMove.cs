using UnityEngine;
using System.Collections;

public class TankMove : MonoBehaviour
{

    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;
    public GameObject bullet;
    public GameObject emitter1;
    public Camera c1;
    public Texture2D up;
    public Texture2D down;
    public Texture2D left;
    public Texture2D right;
    public Texture2D ru;
    public Texture2D rd;
    public Texture2D rl;
    public Texture2D rr;
    public Texture2D Fire;
    public Texture2D tex = null;
    GUIStyle gs = new GUIStyle();

    void Start()
    {
        gs.normal.background = tex;
    }


    void Update()
    {
    }

    void OnGUI()
    {
        if (GUI.RepeatButton(new Rect(40, Screen.height - 80, 40, 40), up, gs) || Input.GetKey("up") || Input.GetKey(KeyCode.W))
        {
            obj1.transform.Translate(obj1.transform.forward * Time.deltaTime * 5, Space.World);
        }
        if (GUI.RepeatButton(new Rect(40, Screen.height - 40, 40, 40), down, gs) || Input.GetKey("down") || Input.GetKey(KeyCode.S))
        {
            obj1.transform.Translate(obj1.transform.forward * Time.deltaTime * -5, Space.World);
        }
        if (GUI.RepeatButton(new Rect(80, Screen.height - 40, 40, 40), right, gs) || Input.GetKey("right") || Input.GetKey(KeyCode.D))
        {
            obj1.transform.Rotate(new Vector3(0, 1, 0), 1);
        }
        if (GUI.RepeatButton(new Rect(0, Screen.height - 40, 40, 40), left, gs) || Input.GetKey("left") || Input.GetKey(KeyCode.A))
        {
            obj1.transform.Rotate(new Vector3(0, -1, 0), 1);
        }
        if (GUI.RepeatButton(new Rect(Screen.width - 120, Screen.height - 40, 40, 40), rl, gs))
        {
            obj2.transform.Rotate(new Vector3(0, -1, 0), 1);
            c1.transform.Rotate(new Vector3(0, -1, 0), 1);
        }
        if (GUI.RepeatButton(new Rect(Screen.width - 40, Screen.height - 40, 40, 40), rr, gs))
        {
            obj2.transform.Rotate(new Vector3(0, 1, 0), 1);
            c1.transform.Rotate(new Vector3(0, 1, 0), 1);

        }
        if (GUI.RepeatButton(new Rect(Screen.width - 80, Screen.height - 80, 40, 40), ru, gs))
        {
            obj3.transform.Rotate(-Vector3.right * Time.deltaTime * 3);
            c1.transform.Rotate(-Vector3.right * Time.deltaTime * 3);
        }
        if (GUI.RepeatButton(new Rect(Screen.width - 80, Screen.height - 40, 40, 40), rd, gs))
        {
            obj3.transform.Rotate(Vector3.right * Time.deltaTime * 3);
            c1.transform.Rotate(Vector3.right * Time.deltaTime * 3);
        }
        if (GUI.Button(new Rect(Screen.width / 2 - 30, Screen.height - 30, 75, 30), Fire, gs))
        {
            GameObject newBullet = (GameObject)Instantiate(bullet);
            Physics.IgnoreCollision(newBullet.GetComponent<Collider>(), emitter1.GetComponent<Collider>());
            newBullet.transform.position = emitter1.transform.position;
            newBullet.GetComponent<Rigidbody>().AddForce(emitter1.transform.up * 1000);

        }
    }
}
