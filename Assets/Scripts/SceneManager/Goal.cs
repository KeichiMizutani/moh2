using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
	[SerializeField]
	Fade fade = null;
	[SerializeField] AudioClip audio;


	private void Start() {
		if(audio) AudioManager.Instance.Play(audio);
	}

	void OnTriggerEnter(Collider col)
	{
        Debug.Log(col);
        
        GameObject.FindObjectOfType<GameManager>().SetScore();
        Debug.Log(GameObject.FindObjectOfType<GameManager>());
		if(col.gameObject.tag == "Player"){
			// SceneManager.LoadScene("Result");
            StartCoroutine(FadeScene());
		}		
	}

    	IEnumerator FadeScene()
	{
		fade.FadeIn (1);
		yield return new WaitForSeconds(1.0f);
		SceneManager.LoadScene("Result");
	}
}
