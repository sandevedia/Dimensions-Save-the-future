using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canoa : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (gameObject.transform.position.y <= -2.83f && gameObject.transform.rotation.z <= 1f )
        {
            GetComponent<Rigidbody2D>().gravityScale = 1;
            
        }
	}
}
