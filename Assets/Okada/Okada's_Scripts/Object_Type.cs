using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Type : MonoBehaviour
{
    [SerializeField, Header("Object Type")] ObjectType _objectType;

    public ObjectType Type { get { return _objectType; } }
}

public enum ObjectType 
{
    Ball
}

