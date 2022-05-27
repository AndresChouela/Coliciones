using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
     void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "muerte")
        {
            //Destroy(gameObject);
            //transform.Translate(0, 0.5F, 0);
             transform.position = new Vector3 (0, 0.5F, 0);
        }
    }
    void OnCollisionExit()
    {
        
    }
    void OnCollisionStay()
    {

    }
}
