using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.UI;

public class GPGSignIn : MonoBehaviour {
	private string access_token;

	public void Awake()
	{
		PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder()
			// requests an ID token be generated.  This OAuth token can be used to
			//  identify the player to other services such as Firebase.
			.RequestIdToken()
			.Build();
		PlayGamesPlatform.InitializeInstance(config);
		PlayGamesPlatform.Activate();
	}

	// Use this for initialization
	void Start () {
		Social.localUser.Authenticate(
			(bool success) => {
				if (success){
					Debug.Log("You've successfully logged in");
					access_token = ((PlayGamesLocalUser) Social.localUser).GetIdToken();
					//Debug.Log(access_token);
					//URL = "https://www.googleapis.com/fitness/v1/users/me/dataSources?access_token=" + access_token;
				}
				else{
					Debug.Log("Login failed for some reason");
				}
			});
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
