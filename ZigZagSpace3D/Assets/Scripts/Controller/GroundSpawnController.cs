using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawnController : MonoBehaviour
{
    public GameObject _lastGroundObject;

    [SerializeField] public GameObject _groundPrefab;

    private GameObject _newGroundObject;

    private int _groundDirection;

    void Start()
    {
        GenerateRandomNewGround();
    }

    public void GenerateRandomNewGround()
    {
        for(int i=0;i<75;i++)
        {
            CreateNewGround();
        }
    }

    private void CreateNewGround()
    {
        _groundDirection = Random.Range(0, 2);

        if(_groundDirection==0)
        {
            _newGroundObject = Instantiate(_groundPrefab, new Vector3(_lastGroundObject.transform.position.x-1f,_lastGroundObject.transform.position.y,_lastGroundObject.transform.position.z), Quaternion.identity);
            _lastGroundObject = _newGroundObject;
        }
        else
        {
            _newGroundObject = Instantiate(_groundPrefab, new Vector3(_lastGroundObject.transform.position.x , _lastGroundObject.transform.position.y, _lastGroundObject.transform.position.z+1f), Quaternion.identity);
            _lastGroundObject = _newGroundObject;
        }


        int _pickUp = Random.Range(0,2);//0-1

        if (_pickUp == 0)
        {
            _groundPrefab.transform.GetChild(0).gameObject.SetActive(true);
            _lastGroundObject = _newGroundObject;
        }
        else
        {
            _groundPrefab.transform.GetChild(0).gameObject.SetActive(false);
            _lastGroundObject = _newGroundObject;
        }
    }
}
