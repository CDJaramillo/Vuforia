using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class AudioVuforia : MonoBehaviour, ITrackableEventHandler 
{
	private TrackableBehaviour mTrackableBehaviour;
	private AudioSource nargaroth;
    void Start()
    {
		nargaroth.GetComponent<AudioSource>();
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }
    public void OnTrackableStateChanged( TrackableBehaviour.Status previousStatus,TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            // Play audio when target is found
            nargaroth.Play();
        }
        else
        {
            // Stop audio when target is lost
            nargaroth.Stop();
        }
    }   
}
