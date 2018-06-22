using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PianoSounds : MonoBehaviour 
{
	public AudioClip[] aClips;
	public AudioSource myAudioSource;
	string btName;
	//Llamamos al componente de audio
	void Start () 
	{
		myAudioSource.GetComponent<AudioSource>();
	}
	//En un if vamos a hacer un raycats detectando los touchs que hagamos, al hacer touch se generará un raycast
	//En el otro if si el racast toca el boton haremos un caso para cada boton y cada boton reproducira un audio.
	//Dichos raycast se detectaran en la posicion de la pantalla.
	void Update () 
	{
		if(Input.touchCount >0 && Input.touches[0].phase == TouchPhase.Began)
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
			RaycastHit hit;
			if(Physics.Raycast(ray,out hit))
			{
				btName = hit.transform.name;
				switch (btName)
				{
					case "Boton1":
					myAudioSource.clip = aClips[0];
					myAudioSource.Play();
					break;

					case "Boton2":
					myAudioSource.clip = aClips[1];
					myAudioSource.Play();
					break;

					case "Boton3":
					myAudioSource.clip = aClips[2];
					myAudioSource.Play();
					break;

					case "Boton4":
					myAudioSource.clip = aClips[3];
					myAudioSource.Play();
					break;

					case "Boton5":
					myAudioSource.clip = aClips[4];
					myAudioSource.Play();
					break;

					case "Boton6":
					myAudioSource.clip = aClips[5];
					myAudioSource.Play();
					break;

					case "Boton7":
					myAudioSource.clip = aClips[6];
					myAudioSource.Play();
					break;
				default:
					break;
				}
			}
		}
	}
}
