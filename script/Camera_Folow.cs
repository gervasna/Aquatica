using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Folow : MonoBehaviour {


	
    public Vector3 offset;
    public Transform target;
    public float smoothspeed = 0.125f;
    // Use this for initialization
    void Start()
    {
        transform.position = target.transform.position - offset;
    }
    void LateUpdate()
    {
        // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
        transform.position = target.transform.position + offset;
    }
}
