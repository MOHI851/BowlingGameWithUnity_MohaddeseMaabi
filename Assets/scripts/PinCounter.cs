using System.Collections;
using System.Collections.Generic;
// PinCounter.cs
using UnityEngine;

public class PinCounter : MonoBehaviour
{
    public BowlingGame bowlingGame;
    public int pointsPerPin = 10;  // امتیاز برای هر پین
    public int fallenPins = 0;
    public StageManager stageManager;

    // این تابع زمانی که یک پین سقوط می‌کند صدا زده می‌شود
    public void PinFallen()
{
    fallenPins++;
    Debug.Log("Pin Fallen: " + fallenPins);  // نمایش تعداد پین‌های سقوط کرده
    BowlingGame bowlingGame = FindObjectOfType<BowlingGame>();
    bowlingGame.AddScore(pointsPerPin);
}

    // تابعی برای محاسبه و افزودن امتیاز بعد از هر نوبت
    public void CalculateScore()
    {
        bowlingGame.AddScore(fallenPins * pointsPerPin);
        fallenPins = 0;  // تعداد پین‌های سقوط کرده را ریست می‌کنیم
    }
}
