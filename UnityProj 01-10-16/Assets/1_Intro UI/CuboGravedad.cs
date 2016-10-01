using UnityEngine;

public class CuboGravedad : MonoBehaviour {

	private Rigidbody rb;

	void Awake ()
	{
		rb = GetComponent<Rigidbody> ();
	}

	public void Caer()
	{
		rb.useGravity = true;
	}

}
