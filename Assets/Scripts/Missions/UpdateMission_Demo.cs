using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateMission_Demo : MonoBehaviour
{
    public void ClearMission(string missionName)
    {
        int currentGrade = GameManager.Instance.playerData.status.Grade;
        GameManager.Instance.playerData.AddClearMission(currentGrade, missionName);
    }
}
