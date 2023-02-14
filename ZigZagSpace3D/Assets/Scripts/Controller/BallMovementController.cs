using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovementController : MonoBehaviour
{
    private BallDatas _ballDatas;

    [SerializeField] private float _ballMoveSpeed;
    [SerializeField] private float _turnSpeed;

    private void Awake()
    {
        _ballDatas = GetComponent<BallDatas>();
    }

    private void Update()
    {
        SetBallMovement();
    }

    private void SetBallMovement()
    {
        transform.position += _ballDatas.GetBallDirection() * _ballMoveSpeed * Time.deltaTime;
        transform.Rotate(Vector3.up * _turnSpeed * Time.deltaTime);

    }
}
