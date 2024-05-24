using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSceneBtn : MonoBehaviour
{
    /// <summary>
    /// 버튼 클릭시 해당 씬으로 이동
    /// </summary>
    /// <param name="nextScene"></param>
    public void LoadSceneBtnOnClick(string nextScene)
    {
        GameManager.Instance.GetComponent<LoadScene>().SceneChange(nextScene);
    }

    public void LoadPreviousSceneBtnOnClick()
    {
        GameManager.Instance.GetComponent<LoadScene>().SceneChangeToPreviousScene();
    }
}
