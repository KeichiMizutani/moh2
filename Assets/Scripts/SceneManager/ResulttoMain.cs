using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ResulttoMain : MonoBehaviour 
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
		SceneManager.LoadScene("Title");
	}
}