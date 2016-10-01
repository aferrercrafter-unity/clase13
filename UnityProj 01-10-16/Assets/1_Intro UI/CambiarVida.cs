using UnityEngine;
using UnityEngine.UI;

public class CambiarVida : MonoBehaviour
{
	private Text cuadroDeTexto;
	private int vida = 0;

	void Awake ()
	{
		cuadroDeTexto = GetComponent<Text> ();
	}

	void Update ()
	{
		if (Input.anyKeyDown)
		{
			vida++;
			cuadroDeTexto.text = "Vida: " + vida.ToString ();
		}
	}
}
