using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour {

	public void next(string a)
	{
		SceneManager.LoadScene(a);
	}
	
	public void QuitGame()
	{
		Debug.Log("Quti !");
Application.Quit();
	}
}
