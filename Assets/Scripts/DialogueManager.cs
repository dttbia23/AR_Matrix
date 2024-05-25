using UnityEngine;
using UnityEngine.UI; // UI 컴포넌트 사용
using TMPro; // TextMeshPro 사용
using UnityEngine.SceneManagement; // 씬 관리

public class DialogueManager : MonoBehaviour
{
    public FadeController fadeController;
    public TMP_Text scriptText; // 대사를 표시하기 위한 변수

    public string[] dialogueLines; // 대사를 저장할 배열
    public int currentLine = 0; // 현재 대사의 위치

    public void DisplayNextLine()
    {
        if (currentLine < dialogueLines.Length)
        {
            scriptText.text = dialogueLines[currentLine];
            currentLine++;
        }
        else // 모든 대사가 출력된 경우
        {
            fadeController.FadeOutAndLoadScene("HomeScene"); // 다음 씬으로 전환
        }
    }
}