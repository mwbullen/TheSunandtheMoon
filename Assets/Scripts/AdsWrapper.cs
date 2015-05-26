using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;

public class AdsWrapper : MonoBehaviour {
	public ShowOptions adShowOptions;
	// Use this for initializat	ion
	void Start () {
		Advertisement.Initialize ("37512");

		adShowOptions = new ShowOptions ();
		adShowOptions.pause = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void PlayAd() {
		if(Advertisement.isReady()){
			Advertisement.Show(null, adShowOptions);
		}
	}
}
