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
		adShowOptions.resultCallback = result => {
			AdComplete ();};
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void AdComplete() {
		Time.timeScale = 1f;
		Time.fixedDeltaTime = .02f;
	}

	public void PlayAd() {
		if(Advertisement.isReady()){
			Advertisement.Show(null, adShowOptions);
		}
	}
}
