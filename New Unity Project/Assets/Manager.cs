using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour {

    public float score;
    public Text scoreUI;

	// Use this for initialization
	void Awake () {
        scoreUI.text = "Score " + score;        
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void Boom()
    {
        score -= 10;
        scoreUI.text = "Score: " + score;
    }
}
