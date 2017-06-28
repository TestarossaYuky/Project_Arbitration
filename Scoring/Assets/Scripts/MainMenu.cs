using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class MainMenu : MonoBehaviour {

    public Text pressText;

    private float waitHide = 0.5f;
    private float waitShow = 0.5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (pressText.IsActive() == true)
        {
            waitHide -= 0.03f;

            if (waitHide <= 0.0f)
            {
                pressText.enabled = false;
                waitHide = 0.5f;
            }
        }
        else
        {
            waitShow -= 0.03f;
            if ( waitShow <= 0.0f)
            {
                pressText.enabled = true;
                waitShow = 0.5f;
            }
        }
		
	}

    public void on_Start_press()
    {
        SceneManager.LoadScene("SelectSport");
    }
}
