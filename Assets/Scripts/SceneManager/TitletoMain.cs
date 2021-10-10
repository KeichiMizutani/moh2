using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitletoMain : MonoBehaviour
{
	[SerializeField]
	Fade fade = null;

	public void OnClick()
	{
		StartCoroutine(FadeScene());
		// fade.FadeIn (1, () =>
		// {
		// 	fade.FadeOut(1);
		// });
	}

	IEnumerator FadeScene()
	{
		fade.FadeIn (1);
		yield return new WaitForSeconds(1.0f);
		SceneManager.LoadScene("Main");
	}
}