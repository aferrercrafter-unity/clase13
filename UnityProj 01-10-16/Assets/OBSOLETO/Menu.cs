using UnityEngine;

public class Menu : MonoBehaviour
{
	void OnGUI()
	{
		GUI.Label (new Rect (0, 0, 200, 100), "Hola!");

		if (GUI.Button (new Rect (0, 150, 200, 100), "Boton")) {

			Debug.Log ("TOCADO");

		}
	}
}
