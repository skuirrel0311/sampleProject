using UnityEngine;
using System.Collections;

public class MazeSpherScript : MonoBehaviour {

    private Color oldc;
    private int counter = 0; //休止の期間を示すカウンタ変数

	// Use this for initialization
	void Start () {
        oldc = gameObject.GetComponent<Material>().color;
	}
	
	// Update is called once per frame
	void Update () {
        MazeAppScript appscript = (MazeAppScript)
            (Camera.main.GetComponent("MazeAppScript"));
        //if (appscript.IsEnd()) return;
        if (counter > 0)
        {
            counter--;
            return;
        }
        gameObject.GetComponent<Material>().color = oldc;

	}
}
