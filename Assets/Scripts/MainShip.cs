using UnityEngine;
using System.Collections;

public class MainShip : Ship {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        this.Move();
	}

    private void Move()
    {
        Vector3 translation = new Vector3();
        if (Input.GetKey(KeyCode.UpArrow))
        {
            translation.z += speed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            translation.z -= speed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            translation.x += speed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            translation.x -= speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            translation.y += speed;
        }
        if (Input.GetKey(KeyCode.Z))
        {
            translation.y -= speed;
        }
        rigidbody.velocity = new Vector3();
        transform.Translate(translation);
    }
}
