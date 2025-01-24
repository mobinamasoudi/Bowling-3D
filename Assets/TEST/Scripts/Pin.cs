using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Pin : MonoBehaviour
{
    public bool _hasFallen;

    

    private void OnCollisionEnter(Collision other)
    {
        if ((other.collider.CompareTag("Ball") || other.collider.CompareTag("Pin")) && !_hasFallen)
        {
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 47e1bc3 (add level2 and sound)

            // محاسبه زاویه چرخش پین نسبت به حالت عمودی
            float currentTilt = Vector3.Angle(transform.up, Vector3.up);

            if (currentTilt > 30f) // اگر زاویه بیش از 30 درجه است، پین افتاده است
            {
                // دریافت اسکریپت توپ
                RollingBall rollingBallScript = FindObjectOfType<RollingBall>();
                if (rollingBallScript != null)
                {
                    rollingBallScript.OnPinFallen(); // ثبت امتیاز برای پین افتاده
<<<<<<< HEAD
=======
=======
            float currentTilt = Vector3.Angle(transform.up, Vector3.up);

            if (currentTilt > 50f) 
            {
                
                RollingBall rollingBallScript = FindObjectOfType<RollingBall>();
                if (rollingBallScript != null)
                {
                    rollingBallScript.OnPinFallen(); 
>>>>>>> 367e0f9 (add level2 and sound)
>>>>>>> 47e1bc3 (add level2 and sound)
                }

                GetComponentInParent<AudioSource>().Play();

<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 47e1bc3 (add level2 and sound)
                // بروزرسانی متن امتیاز
                TextMeshProUGUI scoreText = GameObject.FindGameObjectWithTag("Poing")?.GetComponent<TextMeshProUGUI>();
                if (scoreText != null)
                {
                    scoreText.text = $"Number of fallen pins: {rollingBallScript.currentScore}";
                }

                _hasFallen = true; // جلوگیری از حساب شدن مجدد این پین

                Destroy(gameObject, 1.5f); // حذف پین پس از مدت زمان مشخص
<<<<<<< HEAD
=======
=======
                
                TextMeshProUGUI scoreText = GameObject.FindGameObjectWithTag("Poing")?.GetComponent<TextMeshProUGUI>();
                if (scoreText != null)
                {
                    scoreText.text = $"fallen pins: {rollingBallScript.currentScore}";
                }

                _hasFallen = true; 

                Destroy(gameObject, 1.5f); 
>>>>>>> 367e0f9 (add level2 and sound)
>>>>>>> 47e1bc3 (add level2 and sound)
            }
        }


    }



}
