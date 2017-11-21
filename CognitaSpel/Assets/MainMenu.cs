using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {

    public GameObject[] startMenu;


    public void switchToNewMenu1()
    {
        foreach (GameObject ui in startMenu)
        {
            ui.SetActive(false);
        }



    }
		
	
}
