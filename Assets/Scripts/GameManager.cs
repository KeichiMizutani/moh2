using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    static public float score;

    //プレイヤーのHPをスコアに変換
    public void SetScore()
    {
        // score = GameObject.FindObjectOfType<PlayerHP>().HP;
    }

    //スコアを取得
    public float GetScore()
    {
        return score;
    }
}
