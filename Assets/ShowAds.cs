using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;

public class ShowAds : MonoBehaviour {

	// Use this for initialization
	void Start () {


		Advertisement.Initialize ("28617");
		ShowUnityAds ();
	}

	public void ShowUnityAds()
	{
		if(Advertisement.isReady()){ Advertisement.Show(); } 
		}
	

}
