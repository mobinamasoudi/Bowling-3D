using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Handler : MonoBehaviour
{
    public TextMeshProUGUI fpsDisplay;
    void Start()
    {

    }

<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 47e1bc3 (add level2 and sound)
    // تعداد فریم‌ها و زمان سپری شده
    private int frameCount = 0;
    private float elapsedTime = 0f;

    // به‌روزرسانی نمایش FPS
<<<<<<< HEAD
=======
=======
    
    private int frameCount = 0;
    private float elapsedTime = 0f;

    
>>>>>>> 367e0f9 (add level2 and sound)
>>>>>>> 47e1bc3 (add level2 and sound)
    private void Update()
    {
        frameCount++;
        elapsedTime += Time.deltaTime;

<<<<<<< HEAD
        // هر یک ثانیه FPS را به‌روز کن
=======
<<<<<<< HEAD
        // هر یک ثانیه FPS را به‌روز کن
=======
    
>>>>>>> 367e0f9 (add level2 and sound)
>>>>>>> 47e1bc3 (add level2 and sound)
        if (elapsedTime >= 1f)
        {
            int fps = Mathf.RoundToInt(frameCount / elapsedTime);

<<<<<<< HEAD
            // نمایش مقدار FPS
=======
<<<<<<< HEAD
            // نمایش مقدار FPS
=======
            
>>>>>>> 367e0f9 (add level2 and sound)
>>>>>>> 47e1bc3 (add level2 and sound)
            if (fpsDisplay != null)
            {
                fpsDisplay.text = "FPS: " + fps;
            }

<<<<<<< HEAD
            // مقدارها را بازنشانی کن
=======
<<<<<<< HEAD
            // مقدارها را بازنشانی کن
=======
            
>>>>>>> 367e0f9 (add level2 and sound)
>>>>>>> 47e1bc3 (add level2 and sound)
            frameCount = 0;
            elapsedTime = 0f;
        }
    }

    public void Go_Next(int Level_Index)
    {
<<<<<<< HEAD
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + Level_Index);
=======
<<<<<<< HEAD
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + Level_Index);
=======
        if (SceneManager.GetActiveScene().name == "Level 2")
        {
            SceneManager.LoadScene("Menu");
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + Level_Index);
        }
>>>>>>> 367e0f9 (add level2 and sound)
>>>>>>> 47e1bc3 (add level2 and sound)
    }

    public void Reset_Game()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }



}
