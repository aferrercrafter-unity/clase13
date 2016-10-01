using UnityEngine;

public class CambiadorColor : MonoBehaviour
{
	private Renderer rend;

	void Awake ()
	{
		rend = GetComponent<Renderer> ();
	}

	public void CambiarColor()
	{
		rend.material.color = Random.ColorHSV ();
	}
}
