using UnityEngine;
using System.Collections;

public class Enemy : Ship {
    public Transform target;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(target);
        rigidbody.velocity = new Vector3();
        if (Vector3.Distance(transform.position, target.position) > 28)
        {
            transform.Translate(new Vector3(0, 0, this.speed));
        }

	}
}
