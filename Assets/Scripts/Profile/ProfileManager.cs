using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ProfileManager : MonoBehaviour
{
    [Header("Profile Info")]
    [SerializeField] private TMP_Text profileInfoTxt;
    private string profileInfoFormat = "이화석<br>{0}학년 재학중";


    [Header("Grade Calculator")]
    [SerializeField] private TMP_Dropdown dropdown;


    [Header("Status")]
    [SerializeField] private GameObject status1;


    private void Awake()
    {
        DataManager.LoadPlayerData();
    }

    // Start is called before the first frame update
    void Start()
    {
        profileInfoTxt.text = string.Format(profileInfoFormat, GameManager.Instance.playerData.status.grade);
    }

}
