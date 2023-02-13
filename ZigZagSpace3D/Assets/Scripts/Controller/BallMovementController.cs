using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovementController : MonoBehaviour
{
    [SerializeField] private BallDatas _ballDatas;

    [SerializeField] private float _ballMoveSpeed;

    private void Update()
    {
        SetBallMovement();
    }

    private void SetBallMovement()
    {
        transform.position += _ballDatas.GetBallDirection() * _ballMoveSpeed * Time.deltaTime;
    }

}