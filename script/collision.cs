using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour {
  //  public GameObject boat;
    public GameObject script;
	// Use this for initialization
	void Start () {

    }
    public void OnTriggerEnter(Collider collide)
    {
        //         rb = boat.GetComponent<Rigidbody2D>();
        if (collide.gameObject.name == "ile")
        {
            Debug.Log("trigger avec :" + collide.gameObject.name);
			if(collide.gameObject.tag == "to2") {
				script.SendMessage("exercice2", true);
			}
			if(collide.gameObject.tag == "to3") {
				script.SendMessage("exercice3", true);
			}
			if(collide.gameObject.tag == "diplome") {
				script.SendMessage("diplome", true);
			}
			if(collide.gameObject.tag == "win") {
				script.SendMessage("win", true);
			}
			script.SendMessage("getMessage", true);
			collide.gameObject.GetComponent<BoxCollider>().enabled = false;
		}
        if (collide.gameObject.name == "lim")
        {
            Debug.Log("trigger avec :" + collide.gameObject.name);
            script.SendMessage("outLimit", true);

        }
		if(collide.gameObject.name == "rocher") {
			Debug.Log("trigger avec :" + collide.gameObject.name);
			script.SendMessage("rocher");

		}

	}

    // Update is called once per frame
    //public void Update () {
    //    if (stop)
    //    {           
    //        rb.velocity = new Vector3(0,0,0);
    //        rb.rotation = 0;
    //        stop = false;

    //    }
    //}
}
