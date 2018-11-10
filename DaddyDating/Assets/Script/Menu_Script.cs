﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Script : MonoBehaviour {

	public void StartGame()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
	}
	
	public void QuitGame()
	{
		Debug.Log("You tried to Quit");
		Application.Quit();
	}
}