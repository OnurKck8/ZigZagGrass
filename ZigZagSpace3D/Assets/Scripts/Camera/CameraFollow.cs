using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform _ballTransform;

    private Vector3 _offset;

    private Vector3 _newPosition;

    [SerializeField] [Range(0f,3f)] private float _lerpValue;

    void Start()
    {
        _offset = transform.position - _ballTransform.position;
    }

   
    void LateUpdate()
    {
        SetCameraSmoothFollow();
    }

    private void SetCameraSmoothFollow()
    {
        _newPosition = Vector3.Lerp(transform.position, _ballTransform.position + _offset, _lerpValue * Time.deltaTime);
        transform.position = _newPosition;
    }
}
