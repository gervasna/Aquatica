using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kraken_script : MonoBehaviour {
    public AudioClip saw;

    private void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = saw;
    }
    void OnCollisionEnter()
    {
            GetComponent<AudioSource>().Play();
    }
    // Use this for initialization
 //   void Start () {
		
	//}
	
	//// Update is called once per frame
	//void Update () {
		
	//}
}
