using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundPositionController : MonoBehaviour
{
    private GroundSpawnController _groundSpawnController;

    private Rigidbody rb;

    [SerializeField] private float _endYValue;

    private int _groundDirection;

    

    void Start()
    {
        _groundSpawnController = FindObjectOfType<GroundSpawnController>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckGroundVerticalPos();
    }

    private void CheckGroundVerticalPos()
    {
        if(transform.position.y <= _endYValue)
        {
            SetRigidbodyValue();

            SetGroundNewPos();
        }
    }

    private void SetGroundNewPos()
    {
        _groundDirection = Random.Range(0, 2);

        if (_groundDirection == 0)
        {
            transform.position = new Vector3(_groundSpawnController._lastGroundObject.transform.position.x - 1f, _groundSpawnController._lastGroundObject.transform.position.y, _groundSpawnController._lastGroundObject.transform.position.z);
        }
        else
        {
            transform.position = new Vector3(_groundSpawnController._lastGroundObject.transform.position.x, _groundSpawnController._lastGroundObject.transform.position.y, _groundSpawnController._lastGroundObject.transform.position.z + 1f);
        }

        _groundSpawnController._lastGroundObject = gameObject;
    }

    private void SetRigidbodyValue()
    {
        rb.isKinematic = true;
        rb.useGravity = false;
    }
}
