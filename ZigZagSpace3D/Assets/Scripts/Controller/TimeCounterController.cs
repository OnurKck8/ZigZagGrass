using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeCounterController : MonoBehaviour
{
    TMP_Text _text;
    public float _currentTime;

    void Awake()
    {
        _text = GetComponent<TMP_Text>();
    }

    void Update()
    {
        _currentTime += Time.deltaTime;
        _text.text = _currentTime.ToString("0");//ondalýðý alma demek
    }
}
