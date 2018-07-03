using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneScript : MonoBehaviour {

    public Button btn_next;
    public Button btn_back;

	// Use this for initialization
	void Start ()
    {
        Button btn = btn_next.GetComponent<Button>();
        btn.onClick.AddListener(NextScene);

        Button btn2 = btn_back.GetComponent<Button>();
        btn2.onClick.AddListener(BackScene);
    }

    private void NextScene()
    {
        if (SceneManager.GetSceneByName("scene-1").isLoaded)
        {
            SceneManager.LoadScene("scene-2");
        }
        else if (SceneManager.GetSceneByName("scene-2").isLoaded)

        {
            SceneManager.LoadScene("scene-3");

        }
        else if (SceneManager.GetSceneByName("scene-3").isLoaded)
        {
            Exit();
        }
    }

    private void BackScene()
    {

        if (SceneManager.GetSceneByName("scene-2").isLoaded)
        {
            SceneManager.LoadScene("scene-1");
        }
        else if (SceneManager.GetSceneByName("scene-3").isLoaded)

        {
            SceneManager.LoadScene("scene-2");

        }
        else if (SceneManager.GetSceneByName("scene-1").isLoaded)
        {
            Exit();
        }
    }

    private void Exit()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }

    // Update is called once per frame
    void Update ()
    {

    }

}
