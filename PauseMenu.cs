using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pauseMenu;
    void Start()
    {
         Debug.Log("PauseMenu script loaded");
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {

        
    Debug.Log("RESUME CLICKED");
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!pauseMenu.activeSelf)
            {
                Time.timeScale = 0f;
                pauseMenu.SetActive(true);
                Cursor.visible = true;
            }
            else
            {
                Time.timeScale = 1f;
                pauseMenu.SetActive(false);
                Cursor.visible = false;
            }
        }
    }
    public void quit()
        {
        Application.Quit();
    }
    

public void resume()
    {
         Debug.Log("RESUME CLICKED");
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
        Cursor.visible = false;
    }

}
