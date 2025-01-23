using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // برای استفاده از UI (مثلاً Text)

public class BowlingGame : MonoBehaviour
{
    public int score = 0;  // امتیاز فعلی بازی
    public Text scoreText;  // برای نمایش امتیاز در UI
    public StageManager stageManager;  // مرجع به اسکریپت StageManager
    public PinCounter pinCounter;  // مرجع به اسکریپت PinCounter

    void Start()
    {
        stageManager = FindObjectOfType<StageManager>();
        pinCounter = FindObjectOfType<PinCounter>();
        // برای شروع بازی، امتیاز را صفر می‌کنیم
        score = 0;
        UpdateScore();
         EndTurn();
    }

    // تابعی برای افزودن امتیاز
    public void AddScore(int points)
    {
        score += points;
        Debug.Log("Score Added: " + points + " New Score: " + score); 
        UpdateScore();
    }

    // برای به‌روزرسانی UI و نمایش امتیاز
   void UpdateScore()
{
    if (scoreText != null)  // چک کردن اینکه scoreText به درستی مقداردهی شده باشد
    {
        scoreText.text = "Score: " + score.ToString();
    }
    else
    {
        Debug.LogError("scoreText is not assigned!");
    }
}

    // وقتی که یک نوبت تمام شد، امتیاز و شرایط مرحله را بررسی می‌کنیم
    public void EndTurn()
    {
        pinCounter.CalculateScore();  // محاسبه و افزودن امتیاز برای پین‌های افتاده
        AddScore(pinCounter.fallenPins * 10);  // فرض کنید برای هر پین افتاده 10 امتیاز می‌دهیم
        stageManager.GoToNextStage();  // به مرحله بعدی می‌رویم
    }
}