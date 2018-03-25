using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupTabButton : MonoBehaviour {

    public Button button;
    public GameObject popupScreen; //screen that the button is associated with
    private List<GameObject> possiblePopups = new List<GameObject>();

    void Awake()
    {
        //find the children of center screen
        GameObject CenterScreen = GameObject.Find("Center Screen");
        //append each of them to the list of possible popups
        int screensCount = CenterScreen.transform.childCount;
        for (int x = 0; x < screensCount; x++){
            GameObject child = CenterScreen.transform.GetChild(x).gameObject;
            possiblePopups.Add(child);
        }

        //Check that this Button exists
        if (button != null)
        {
            //Call the LoadScene2Button() function when this Button is clicked
            button.onClick.AddListener(TogglePopupTab);
        }
    }
    void TogglePopupTab()
    {
        bool repeatedButton = false;
        //closes all screens
        for (int x = 0; x < possiblePopups.Count; x++) {
            //check if the player is closing the screen
            if(possiblePopups[x].activeSelf && possiblePopups[x] == popupScreen) {
                repeatedButton = true;
            }
            possiblePopups[x].SetActive(false);
        }
        //opens screen if player is not closing a screen
        if (!repeatedButton) {
            popupScreen.SetActive(true);
        }
    }
}
