using UnityEngine;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour {

    private AudioSource s;
    public Slider sl;
	// Use this for initialization
	void Awake () {
        s = GetComponent<AudioSource>();
        s.volume = sl.value;
	}

    public void Music(bool active)
    {
        if (active)
            s.Play();
        else
            s.Stop();
    }
}
