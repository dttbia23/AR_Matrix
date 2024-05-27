using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ProfileManager : MonoBehaviour
{
    [Header("Profile Info")]
    [SerializeField] private TMP_Text profileInfoTxt;
    private string profileInfoFormat = "이화석<br>{0}학년 재학중";


    [Header("Grade Calculator")]
    [SerializeField] private TMP_Dropdown dropdown;


    [Header("Status")]
    [SerializeField] private Slider healthProgressBar;
    [SerializeField] private Slider attractivenessProgressBar;
    [SerializeField] private Slider intelligenceProgressBar;


    private void Awake()
    {
        DataManager.LoadPlayerData();
    }

    // Start is called before the first frame update
    void Start()
    {
        //profile info text 설정(학년 반영)
        profileInfoTxt.text = string.Format(profileInfoFormat, GameManager.Instance.playerData.status.grade);

        //status 수치 반영
        healthProgressBar.value = GameManager.Instance.playerData.status.health;
        attractivenessProgressBar.value = GameManager.Instance.playerData.status.attractiveness;
        intelligenceProgressBar.value = GameManager.Instance.playerData.status.intelligence;

    }

}
