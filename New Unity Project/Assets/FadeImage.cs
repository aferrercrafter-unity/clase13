using UnityEngine;
using UnityEngine.UI;

public class FadeImage : MonoBehaviour {

	// Use this for initialization
    float elapsed;
    float rate = 0.5f;
    bool fading = false;
    private Image i;

    void Awake()
    {
        i = GetComponent<Image>();
    }

    void Update()
    {
        if (fading == true)
            if (i.color.a > 0) {
                i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a - rate * Time.deltaTime);
                Debug.Log("fade");
            }
                

    }

    public void Fade()
    {
        fading = true;
    }



}
