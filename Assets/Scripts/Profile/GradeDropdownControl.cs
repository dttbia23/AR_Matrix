using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GradeDropdownControl : MonoBehaviour
{
    [SerializeField]
    private TMP_Dropdown gradeDropdonw;
    [SerializeField] private int currentGrade;

    void Start()
    {
        //현재 학년을 가져온다.
        currentGrade = GameManager.Instance.playerData.status.grade;


        // 옵션 리스트를 생성
        List<TMP_Dropdown.OptionData> options = new List<TMP_Dropdown.OptionData>();

        // 현재 학년까지 옵션을 추가
        for (int i = 0; i < currentGrade; i++)
        {
            string optionText = $"{i + 1}학년";
            options.Add(new TMP_Dropdown.OptionData(optionText));
        }
        //드롭다운에 옵션리스트 추가
        gradeDropdonw.AddOptions(options);
    }

}
