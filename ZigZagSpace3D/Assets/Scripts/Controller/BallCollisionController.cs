using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollisionController : MonoBehaviour
{
    public GameObject ps;
    public AudioSource _sound;
    public GameObject _gameOverPanel;
    GroundSpawnController _groundSpawnController;
    private void Awake()
    {
        _gameOverPanel.SetActive(false);

        _groundSpawnController = FindObjectOfType<GroundSpawnController>().GetComponent<GroundSpawnController>();
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
            other.gameObject.SetActive(false);

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
