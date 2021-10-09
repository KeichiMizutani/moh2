

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    [SerializeField] Text result;
    [SerializeField] Text evaluation;
    [SerializeField] Text comment;

    void Start()
    {
        result.text = GameManager.score.ToString("f0");

        if (GameManager.score >= 90)
        {
            evaluation.text = "S";
            comment.text = "大変よくできました";
        }
        else if (GameManager.score < 90 && GameManager.score >= 80)
        {
            evaluation.text = "A";
            comment.text = "なかなか良い出来です";
        }
        else if (GameManager.score < 80 && GameManager.score >= 70)
        {
            evaluation.text = "B";
            comment.text = "悪くないです";
        }
        else if (GameManager.score < 70 && GameManager.score >= 60)
        {
            evaluation.text = "C";
            comment.text = "努力の跡は見えました";
        }
        else
        {
            evaluation.text = "F";
            comment.text = "なに書いているのかわかりません";
        }
    }

}
