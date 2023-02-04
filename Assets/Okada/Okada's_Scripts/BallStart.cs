using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This is a script that places the ball in position at the play's start.
/// </summary>

public class BallStart : MonoBehaviour
{
    /// <summary>  Vector3 for ball in the position </summary>
    [SerializeField, Header(" Start Position")] Vector3 _ballStartPosition;
    void Start()
    {
        PlayStart();
    }

    /// <summary>
    ///  Method for setting the starting position of the ball
    /// </summary>
    void PlayStart()
    {
        transform.position = _ballStartPosition;
    }
}
