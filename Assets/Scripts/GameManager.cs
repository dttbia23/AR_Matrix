using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Status
{
    public int grade;
    public int intelligence;
    public int attractiveness;
    public int health;
}

public class GameManager : MonoBehaviour
{
    #region Singleton
    private static GameManager instance = null;
    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<GameManager>();
                if (instance == null)
                {
                    GameObject go = new GameObject();
                    go.name = "SingletonController";
                    instance = go.AddComponent<GameManager>();
                    DontDestroyOnLoad(go);
                }
            }
            return instance;
        }
    }
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
            Destroy(gameObject);
    }
    #endregion

    public string nowMissionCode; // 현재 미션 정보
    public Status playerStatus;




    #region Status Up and Down
    /// <summary>
    /// num으로 학년 바꾸기 (1~4)
    /// </summary>
    /// <param name="num"></param>
    public void ChangeGrade(int num)
    {
        playerStatus.grade = num;
    }

    public void IntelligenceStatusUpDown(int num)
    {
        playerStatus.intelligence += num;
    }
    public void AttractivenessStatusUpDown(int num)
    {
        playerStatus.attractiveness += num;
    }
    public void HealthStatusUpDown(int num)
    {
        playerStatus.health += num;
    }
    #endregion
}
