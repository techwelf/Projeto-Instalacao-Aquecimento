using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneScript : MonoBehaviour {


    public Button show;

	// Use this for initialization
	void Start () {
        Button btn = show.GetComponent<Button>();
        btn.onClick.AddListener(ShowObject);
	}

    private void ShowObject()
    {
        if (SceneManager.GetSceneByName("projeto-tese").isLoaded)
        {
            SceneManager.LoadScene("projeto-tese-2");
        }
        else if (SceneManager.GetSceneByName("projeto-tese-2").isLoaded)

        {
            SceneManager.LoadScene("projeto-tese-3");

        }

    }
        // Update is called once per frame
        void Update () {
		
	}
}
