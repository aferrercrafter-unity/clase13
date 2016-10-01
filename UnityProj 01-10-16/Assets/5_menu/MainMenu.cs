using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void CargarGameplay()
	{
		SceneManager.LoadScene ("juego");
	}

	public void SalirDelJuego()
	{
		Application.Quit ();
	}
}
