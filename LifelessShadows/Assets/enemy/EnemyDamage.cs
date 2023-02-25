using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int EnemyHealth = 100;
    private Health PlayerHealth;

    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        PlayerHealth = player.GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        if (EnemyHealth <= 0) 
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerStay(Collider other) {
        if (other.CompareTag("Player")) {
            Damage(1);
        }
    }
    public void Damage(int damage) 
    {
        PlayerHealth.health -= damage;
    }
}
