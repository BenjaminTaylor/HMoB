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
    public static int _currentScore;

    #endregion


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
}