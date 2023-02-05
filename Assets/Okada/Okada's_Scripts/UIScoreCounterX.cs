using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


/// <summary>
/// This is a UI related script.
/// </summary>

public class UIScoreCounterX : MonoBehaviour
{
    #region private SerializeField

    /// <summary> Current score UI</summary>
    [SerializeField, Header("ScoreUI")] TextMeshProUGUI _scoreUI;

    /// <summary> Score at start</summary>
    [SerializeField, Header("Score in Play")] int _startScore;

    #endregion

    #region public static

    /// <summary> Variables for saving scores in game</summary>
    public static float _currentScore;

    #endregion

    public GameObject ball;
    public Vector3 ballResetPosition;

    void Start()
    {
        SetScore();
    }

    // Update is called once per frame
    void Update()
    {


    }

    void SetScore()
    {
        _currentScore = _startScore;

        _scoreUI.text = _currentScore.ToString();

    }

    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == "Player_Ball_Blue")
        {
            ball.transform.position = ballResetPosition;
            _currentScore += 0.5f;
            
            _scoreUI.text = _currentScore.ToString();

        }
    }
}