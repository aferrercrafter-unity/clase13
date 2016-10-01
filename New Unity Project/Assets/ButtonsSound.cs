using UnityEngine;
using System.Collections;

public class ButtonsSound : MonoBehaviour {

    private AudioSource s;
    void Awake(){
        s = GetComponent<AudioSource>();
    }

    public void Press()
    {
        s.Play();
    }

}
