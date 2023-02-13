using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundColorManager : MonoBehaviour
{
    [SerializeField] private Material _groundMaterial;
    [SerializeField] private Color[] _colors;
    private int _colorIndex = 0;

    [SerializeField] private float _lerpValue;
    [SerializeField] private float _time;
    private float _currentTime;

    private void Update()
    {
        SetColorChange();
        SetGroundMaterialSmoothColorChange();
    }

    private void SetColorChange()
    {
        if(_currentTime <= 0)
        {
            CheckColorIndexValue();
            _currentTime = _time;
        }
        else
        {
            _currentTime -= Time.deltaTime;
        }
    }

    private void CheckColorIndexValue()
    {
        _colorIndex++;

        if(_colorIndex>=_colors.Length)
        {
            _colorIndex = 0;
        }
    }
    private void SetGroundMaterialSmoothColorChange()
    {
        _groundMaterial.color = Color.Lerp(_groundMaterial.color,_colors[_colorIndex],_lerpValue*Time.deltaTime);
    }
    private void OnDestroy()
    {
        _groundMaterial.color = _colors[1];
    }
}
