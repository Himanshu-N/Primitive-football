using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    [SerializeField] GameObject DeadMsg;
    
    [SerializeField] GameObject GoalChek;
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Die();
            DeadMsg.SetActive(true);
        }
    }

    public void Die()
    {
        // Time.timeScale = 0;
        // gameObject.GetComponent<MeshRenderer>().enabled = false;
        gameObject.GetComponent<Rigidbody>().isKinematic = true;
        gameObject.GetComponent<Movement>().enabled = false;
        Destroy(GoalChek);
    }
}
