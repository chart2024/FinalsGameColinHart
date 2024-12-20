using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Ball")]
    public GameObject Ball;

    [Header("Player 1")]
    public GameObject Player1;
    public GameObject Player1Goal;

    [Header("Player 2")]
    public GameObject Player2;
    public GameObject Player2Goal;

    [Header("Score #")]
    public GameObject Player1Number;
    public GameObject Player2Number;

    private int Player1Score;
    private int Player2Score;

    public void Player1Scored()
    {
        Player1Score++;
        Player1Number.GetComponent<TextMeshProUGUI>().text = Player1Score.ToString();
        ResetPosition();
    }

    public void Player2Scored()
    {
        Player2Score++;
        Player2Number.GetComponent<TextMeshProUGUI>().text = Player2Score.ToString();
        ResetPosition();
    }
    private void ResetPosition()
    {
        Ball.GetComponent<Ball>().Reset();
        Player1.GetComponent<WASD_Player1>().Reset();
        Player2.GetComponent<OL_Player2>().Reset();
    }


}
