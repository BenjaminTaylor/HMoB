using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///  This is a script to generate object randomly in x- and z-axis directions
/// </summary>

public class GrowRoot : MonoBehaviour
{
    /// <summary>Variable for calling the generating of objects.</summary>
    [SerializeField, Header("Call Object")] GameObject _generateObj;

    /// <summary>x-axis's Min Variable to randomly generate</summary>
    [SerializeField] float _xMin;

    /// <summary>x-axis's Max Variable to randomly generate</summary>
    [SerializeField] float _xMax;

    /// <summary>y-axis's Pos Variable to randomly generate</summary>
    [SerializeField] float _yPos;

    /// <summary>z-axis's Min Variable to randomly generate</summary>
    [SerializeField] float _zMin;

    /// <summary>z-axis's Max Variable to randomly generate</summary>
    [SerializeField] float _zMax;

    /// <summary>Variables for calling the object you want to generate
    ///from another script.(If necesarry)</summary>
    public GameObject GenerateObj { get { return _generateObj; } set { _generateObj = value; } }

    /// <summary>
    /// Method to generate object at random
    /// </summary>
    void Start()
    {
        // set x-axis range
        float xPos = Random.Range(_xMin, _xMax);
        // set y-axis 
        float yPos = _yPos;
        // set z-axis range
        float zPos = Random.Range(_zMin, _zMax);

        // set x,y & z - axis position to randomly generate
        Vector3 randomPos = new Vector3(xPos, yPos, zPos);
        // call generating of object at random
        Instantiate(_generateObj, randomPos, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
