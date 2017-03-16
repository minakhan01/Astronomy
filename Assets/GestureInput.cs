using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestureInput : MonoBehaviour {

    private Vector3 position;
    public GameObject line;
    public GameObject ball;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        line.GetComponent<LineRenderer>().SetPosition(1, position*3);
        line.GetComponent<LineRenderer>().SetWidth(0.2f + Mathf.Abs(position.z), 0.2f);
    }

    public void updatePosition(Vector3 newPosition) {
        position = newPosition;
    }

    public void updateFinished(Vector3 newPosition)
    {
        position = newPosition;
        Time.timeScale = 1;
        ball.GetComponent<Rigidbody>().AddForce(new Vector3(position.x*10, position.y*10, 10*Mathf.Abs(position.z)), ForceMode.Force);
    }
}
