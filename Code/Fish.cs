using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour {

    [SerializeField]
    private float _upwardForceMultiplier = 100f;
	
	// Update is called once per frame
	void Update () {
        bool pressedFireButton = Input.GetButtonDown("Fire1");
        if (pressedFireButton)
        {
            Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
            rigidbody.velocity = Vector3.zero;
            rigidbody.AddForce(Vector3.up * _upwardForceMultiplier);
        }

        if (transform.position.y > 5f || transform.position.y < -5f)
        {
            Application.LoadLevel(0);
        }
	}
}
