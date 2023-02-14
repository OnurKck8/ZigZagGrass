using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDatas : MonoBehaviour
{
    private BallInputController _ballInputController;

    private void Awake()
    {
        _ballInputController = GetComponent<BallInputController>();
    }

    public Vector3 GetBallDirection()
    {
        return _ballInputController.ballDirection; 
    }
}
