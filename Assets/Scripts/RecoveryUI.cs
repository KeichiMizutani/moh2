using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecoveryUI : MonoBehaviour
{
    	private Text recoveryText;
	//　フェードアウトするスピード
	private float fadeOutSpeed = 2f;
	//　移動値
	[SerializeField]
	private float moveSpeed = 0.4f;
 
	void Start () {
		recoveryText = GetComponentInChildren<Text>();
	}
 
	void LateUpdate () {
		transform.rotation = Camera.main.transform.rotation;
		transform.position += Vector3.up * moveSpeed * Time.deltaTime;
 
        recoveryText.color = Color.Lerp(recoveryText.color, new Color(0f, 1f, 0f, 0f), fadeOutSpeed * Time.deltaTime);
 
        if (recoveryText.color.a <= 0.1f) {
            Destroy(gameObject);
        }
    }
}
