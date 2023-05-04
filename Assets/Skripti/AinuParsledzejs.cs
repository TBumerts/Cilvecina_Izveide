using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class AinuParsledzejs : MonoBehaviour {

	// Use this for initialization
	public void uzMain () {
		SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
	}
	
	// Update is called once per frame
	public void uzPargerbsanu () {
		SceneManager.LoadScene("Ainas", LoadSceneMode.Single);
	}
	public void Apturet() { 
		Application.Quit();
	}
}
