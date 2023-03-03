using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParicleSystemController : MonoBehaviour
{
    private ParticleSystem _ps;
    void Start()
    {
        _ps = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!_ps.isPlaying)
        {
            Destroy(gameObject);
        }
    }
}
