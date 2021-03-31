using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Enemy_Attack : MonoBehaviour
{
    public GameObject player;
    public Text textComponent;
    public float enemyDamage = 1f;

    public GameObject playerHealthScript;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject == player)
        {
            playerHealthScript.GetComponent<Health>().currentHealth =
                playerHealthScript.GetComponent<Health>().currentHealth - enemyDamage;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
