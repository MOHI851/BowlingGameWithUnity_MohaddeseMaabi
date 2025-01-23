using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManager : MonoBehaviour
{
    public int currentStage = 1;
    public int totalStages = 5;

    public void GoToNextStage()
    {
        currentStage++;
        if (currentStage > totalStages)
        {
            // بازی تمام شده است
            Debug.Log("Game Over");
        }
        else
        {
            // مراحل جدید را بارگذاری کنید
            Debug.Log("Stage " + currentStage);
        }
    }
}
