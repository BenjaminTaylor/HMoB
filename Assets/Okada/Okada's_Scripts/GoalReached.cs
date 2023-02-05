using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This is a script to detect when the ball has collided with the goal peg
/// </summary>

public class GoalReached : MonoBehaviour
{
    /// <summary> Variable for Object_Type class</summary>
    Object_Type _type;

    /// <summary> Methods when the balls began to collide</summary>
    /// <param name="col"></param>
    void OnCollisionEnter(Collision col)
    {
        // Get the collision of the object with Object_type.cs
        _type = col.gameObject.GetComponent<Object_Type>();

        // If Type equals ObjectType.Ball ÅEÅEÅE
        if (_type.Type == ObjectType.Ball)
        {
            Debug.Log("Hit!!");
        }
    }
}
