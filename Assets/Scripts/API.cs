using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class API : MonoBehaviour {

    // Use this for initialization

    private const string URL = "http://www.omdbapi.com/?t=avengers&type=movie&apikey=e15d9329";
    public Text responseText;

    public void Request()
    {
        WWW request = new WWW(URL);
        StartCoroutine(OnResponse(request));
    }

    private IEnumerator OnResponse(WWW req)
    {
        yield return req;

        responseText.text = req.text;
    }
}
