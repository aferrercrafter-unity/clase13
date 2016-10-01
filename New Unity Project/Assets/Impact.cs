using UnityEngine;
using System.Collections;

public class Impact : MonoBehaviour {

    public float force;
    private GameObject manager;

	// Use this for initialization
	void Awake () {
        manager = GameObject.FindGameObjectWithTag("Manager");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision col)
    {
        Rigidbody r = col.gameObject.GetComponent<Rigidbody>();
        r.AddExplosionForce(force, col.contacts[0].point, 50, 0, ForceMode.Impulse);
        manager.SendMessage("Boom");
        Debug.Log("Boomb");
    }
}
