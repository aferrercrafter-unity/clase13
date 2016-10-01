using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    private Rigidbody rb;
    public float speed;
    private float vertical;
    private float horizontal;

	// Use this for initialization
	void Awake () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame

    void FixedUpdate()
    {
        vertical = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        horizontal = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
    }

	void Update () {

        rb.AddForce(Vector3.forward * vertical);
        rb.AddForce(Vector3.right * horizontal);

	}
}
