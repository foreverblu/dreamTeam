using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayButtonTransition : MonoBehaviour {
    
    bool m_SceneLoaded;
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
        //Check that the second Scene hasn't been added yet
        if (m_SceneLoaded == false)
        {
            SceneManager.LoadScene(sceneText, LoadSceneMode.Single);
            SceneManager.SetActiveScene(SceneManager.GetSceneByName(sceneText));
        }
    }

}
