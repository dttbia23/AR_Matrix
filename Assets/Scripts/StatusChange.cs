using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusChange : MonoBehaviour
{
    GameManager gameManager;

    private void Start()
    {
        gameManager = GameManager.Instance;
    }

    public void ChangeGrade(int num)
    {
        gameManager.ChangeGrade(num);
    }

    public void IntelligenceStatusUpDown(int num)
    {
        gameManager.IntelligenceStatusUpDown(num);
    }
    public void AttractivenessStatusUpDown(int num)
    {
        gameManager.AttractivenessStatusUpDown(num);
    }
    public void HealthStatusUpDown(int num)
    { 
        gameManager.HealthStatusUpDown(num);
    }
}
