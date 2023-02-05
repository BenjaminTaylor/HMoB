using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseControlled : MonoBehaviour
{
    public Vector3 SetMalletPosition;
    public float MalletHeadHeight;
    public Vector2 BoardLowerBoundingLimit;
    public Vector2 BoardUpperBoundingLimit;

    void Start()
    {
        SetMalletPosition.Set(0.3f, MalletHeadHeight, -4f);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //left mouse button click
        {
                Debug.Log("Trigger Automated Hit Animation");
        }
        SetMalletPosition.Set(((Input.mousePosition.x - Screen.width) / Screen.width) * (BoardUpperBoundingLimit.x - BoardLowerBoundingLimit.x), MalletHeadHeight, ((Input.mousePosition.y - Screen.height) / Screen.height) * (BoardUpperBoundingLimit.y - BoardLowerBoundingLimit.y));//Input.mousePosition;
        this.transform.position = SetMalletPosition;
    }
}
