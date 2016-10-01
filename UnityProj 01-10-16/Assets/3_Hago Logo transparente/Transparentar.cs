using UnityEngine;
using UnityEngine.UI;

public class Transparentar : MonoBehaviour {

	private Image image;

	private bool transparentarOn = false;
	private float alpha = 1.0f;

	void Awake ()
	{
		image = GetComponent<Image> ();
	}

	void Update ()
	{
		if (transparentarOn)
		{
			alpha -= Time.deltaTime;
			image.color = new Color (1, 1, 1, alpha);

			if (alpha <= 0.0f)
			{
				transparentarOn = false;
			}
		}
	}

	public void HacerTransparente()
	{
		transparentarOn = true;
	}
}
