using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Handler : MonoBehaviour
{
    
    public GameObject settingPanel;

<<<<<<< HEAD
    // Start is called before the first frame update
=======
<<<<<<< HEAD
    // Start is called before the first frame update
=======
    
>>>>>>> 367e0f9 (add level2 and sound)
>>>>>>> 47e1bc3 (add level2 and sound)
    void Start()
    {
        
        if (settingPanel != null)
        {
            settingPanel.SetActive(false);
        }
    }

<<<<<<< HEAD
    // Update is called once per frame
=======
<<<<<<< HEAD
    // Update is called once per frame
=======
    
>>>>>>> 367e0f9 (add level2 and sound)
>>>>>>> 47e1bc3 (add level2 and sound)
    void Update()
    {

    }

    
    public void Play_Button()
    {
        
<<<<<<< HEAD
        SceneManager.LoadScene("Level 1");
=======
<<<<<<< HEAD
        SceneManager.LoadScene("Level 1");
=======
        SceneManager.LoadScene("Level 1"); 
>>>>>>> 367e0f9 (add level2 and sound)
>>>>>>> 47e1bc3 (add level2 and sound)
    }

    
    public void Setting()
    {
        if (settingPanel != null)
        {
            
            settingPanel.SetActive(!settingPanel.activeSelf);
        }
    }

    
    public void Exit()
    {
        
        Application.Quit();
    
    }
}
