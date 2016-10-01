using UnityEngine;
using System.Collections;

public class ColorChange : MonoBehaviour {

    private Renderer r;

    void Awake(){
        r = GetComponent<Renderer>();
    }

    public void Change()
    {
        r.material.color = Random.ColorHSV();
    }

}
