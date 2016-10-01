using UnityEngine;
using UnityEngine.UI;

public class Welcome : MonoBehaviour {

    public float fade = 3;
    private float elapsed = 0;
    private bool show = false;
    private Text t;
	// Use this for initialization
	void Awake () {
        t = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        if (elapsed >= fade)
        {
            show = false;
            elapsed = 0;
            this.gameObject.SetActive(false);
        }
        if (show)
        {
            elapsed += Time.deltaTime;
        }        
	}

    public void enter(string nick){
        t.text = "Welcome " + nick;
        show = true;
    }
}
