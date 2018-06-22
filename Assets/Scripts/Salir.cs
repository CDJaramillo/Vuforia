using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using System;
public class Salir : MonoBehaviour
{	public void Update()
	{
		if (Application.platform == RuntimePlatform.Android)
		{
			if(Input.GetKeyUp (KeyCode.Escape))
			{
				Application.Quit();
				return;
			}
		}
	}
}