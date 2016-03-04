using UnityEngine;
using System.Collections;

public class CameraViewScript : MonoBehaviour {
	public Transform target;

	// Use this for initialization
	void Start () {
		Vector3 vec = target.position;
        Vector3 fvec = target.forward;

        vec.y = 2.5f;
        fvec *= 4f;
        fvec.y = -1f;

        Camera.main.transform.position = vec - fvec;
        Camera.main.transform.LookAt(vec);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
