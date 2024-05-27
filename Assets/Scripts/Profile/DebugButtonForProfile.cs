using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugButtonForProfile : MonoBehaviour
{
    [SerializeField] private ProfileManager profileManager;
    public void IntelligenceUp(int num)
    {
        GameManager.Instance.playerData.status.intelligence += num;
        profileManager.SetStatusProgressBar();
    }
    public void AttractivenessUp(int num)
    {
        GameManager.Instance.playerData.status.attractiveness += num;
        profileManager.SetStatusProgressBar();
    }
    public void HealthUp(int num)
    {
        GameManager.Instance.playerData.status.health += num;
        profileManager.SetStatusProgressBar();
    }

    public void ResetPlayerData()
    {
        DataManager.Reset();
        profileManager.RefreshUI();
    }
}
