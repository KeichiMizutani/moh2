using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    static public float score;

    //プレイヤーのHPをスコアに変換
    public void SetScore()
    {
        score = GameObject.FindObjectOfType<PlayerHP>().HP;
        Debug.Log(score);
    }

    //スコアを取得
    public float GetScore()
    {
        Debug.Log(score);
        return score;
    }
}
