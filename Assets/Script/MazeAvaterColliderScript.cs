using UnityEngine;
using System.Collections;

public class MazeAvaterColliderScript : MonoBehaviour {

    public bool collisionFlg = true; //衝突状況を示すフラグ変数

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

    void OnTriggerEnter(Collider collider)
    {
        collisionFlg = false;
        MazeAppScript appscript = (MazeAppScript)
            (Camera.main.GetComponent("MazeAppScript"));
        //appscript.LossPower(1);
    }

    void OntriggerExit(Collider collider)
    {
        collisionFlg = true;
    }
}
