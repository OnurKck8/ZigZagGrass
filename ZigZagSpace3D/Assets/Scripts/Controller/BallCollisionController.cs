using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollisionController : MonoBehaviour
{
    public GameObject ps;
    public AudioSource _sound;
    public GameObject _gameOverPanel;

    private void Awake()
    {
        _gameOverPanel.SetActive(false);
    }

    private void Update()
    {
        if (!_gameOverPanel.activeSelf)
        {
            Time.timeScale = 1f;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="PickUp")
        {
            Instantiate(ps, transform.position, Quaternion.identity);
            _sound.Play();

            Destroy(other.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            if (!_gameOverPanel.activeSelf)
            {
                _gameOverPanel.SetActive(true);
                Time.timeScale = 0f;
            }
            
        }
            
    }
}
