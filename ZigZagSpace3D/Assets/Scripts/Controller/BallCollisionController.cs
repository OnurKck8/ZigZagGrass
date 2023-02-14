using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollisionController : MonoBehaviour
{
    public GameObject ps;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="PickUp")
        {
            Instantiate(ps, transform.position, Quaternion.identity);
            Destroy(other.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {      
            Time.timeScale = 0f;
        }
            
    }
}
