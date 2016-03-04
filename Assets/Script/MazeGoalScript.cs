using UnityEngine;
using System.Collections;

public class MazeGoalScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        //ゴールを回転させる
        transform.Rotate(new Vector3(1,1,1));
	}

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Player")
        {
            MazeAppScript appscript = (MazeAppScript)
                (Camera.main.GetComponent("MazeAppScript"));
            //appscript.GoodEnd();
        }
    }
}
