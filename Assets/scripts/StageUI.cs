using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageUI : MonoBehaviour
{
    public Text stageText;            // برای نمایش شماره مرحله
    public StageManager stageManager; // برای دسترسی به StageManager
    
    void Update()
    {
        // به‌روز کردن متن UI با شماره مرحله فعلی
        stageText.text = "Stage: " + stageManager.currentStage;
    }
}

