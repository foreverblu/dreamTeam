using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayButtonTransition : MonoBehaviour {
    
    public Button button;
    public string sceneText;

    void Awake()
    {
        //Check that this Button exists
        if (button != null)
        {
            //Call the LoadScene2Button() function when this Button is clicked
            button.onClick.AddListener(LoadScene2Button);
        }
    }

    //Load the second Scene when this Button is pressed
    void LoadScene2Button()
    {
        SceneManager.LoadScene(sceneText, LoadSceneMode.Single);
        SceneManager.SetActiveScene(SceneManager.GetSceneByName(sceneText));
    }

}
