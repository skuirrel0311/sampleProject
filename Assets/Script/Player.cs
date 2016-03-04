using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public float speed = 5.0f;
	// Update is called once per frame
	void Update () {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 vec = new Vector3();

        vec.x = h;
        vec.z = v;

        GetComponent<Rigidbody>().velocity = vec.normalized * speed;

	}
}
