using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;


public class FadeController : MonoBehaviour
{
    public Image fadeImage; // 페이드에 사용할 Image 컴포넌트
    public float fadeSpeed = 3f; // 페이드 속도

    // 페이드 인을 시작
    public void FadeIn()
    {
        StartCoroutine(FadeInCoroutine());
    }

    // 페이드 아웃을 시작하고, 씬을 전환
    public void FadeOutAndLoadScene(string sceneName)
    {
        StartCoroutine(FadeOutCoroutine(sceneName));
    }

    IEnumerator FadeInCoroutine()
    {
        // 투명도를 1에서 0으로 변경
        float alpha = fadeImage.color.a;
        while (alpha > 0f)
        {
            alpha -= Time.deltaTime * fadeSpeed;
            fadeImage.color = new Color(1, 1, 1, alpha);
            yield return null;
        }
    }

    IEnumerator FadeOutCoroutine(string sceneName)
    {
        // 투명도를 0에서 1로 변경
        float alpha = fadeImage.color.a;
        while (alpha < 1f)
        {
            alpha += Time.deltaTime * fadeSpeed;
            fadeImage.color = new Color(1, 1, 1, alpha);
            yield return null;
        }

        // 씬 전환
        SceneManager.LoadScene(sceneName);
    }
}
