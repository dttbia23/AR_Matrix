using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using TMPro;


public class DialogueManager : MonoBehaviour, IPointerClickHandler
{
    public TMP_Text textScripts; // TextScripts 컴포넌트를 연결하기 위한 변수
    public Image dialogueImage;
    public FadeController fadeController;

    // 대화 내용을 저장할 배열
    private string[] dialogues = {
        "나, 컴퓨터공학과 20학번 김화연.\n오늘은 기다리고 기다리던 졸업날!\n학교를 5년동안이나 다녔으니...\n이제는 정말 졸업할 때가 됐어!\n신난다~",
        "그런데 이게 무슨 일이야!\n채플, 필수교양, 필수전공,\n영어 성적, 졸업 시험 등등\n이화여자대학교 컴퓨터공학과\n학생이라면 갖춰야할 졸업요건을 내가 미충족했다구?!\n그럼 내가 졸업을 못한다구?!!",
        "제발...\n1학년으로 돌아갈 수 있다면...\n못들은 강의도 듣고, 시험도 치고,\n알차게 학교 생활을 즐길텐데...!",
        "어, 그런데 저 빛은 뭐지?"
    };

    public Sprite[] dialogueImages;
    private int currentDialogueIndex = 0; // 현재 대화의 인덱스

    public void OnPointerClick(PointerEventData eventData)
    {
        currentDialogueIndex++; // 다음 대화로 이동

        if (currentDialogueIndex < dialogues.Length)
        {
            // 아직 표시할 대화가 남아있으면 대화 내용 업데이트
            textScripts.text = dialogues[currentDialogueIndex];
        }
        else
        {
            // 모든 대화가 끝나면 페이드 아웃하고 새로운 씬으로 전환
            fadeController.FadeOutAndLoadScene("HomeScene");
        }
    }

    void Start()
    {
        // 초기 대화 내용 설정
        textScripts.text = dialogues[currentDialogueIndex];
        dialogueImage.sprite = dialogueImages[currentDialogueIndex];
    }
}
