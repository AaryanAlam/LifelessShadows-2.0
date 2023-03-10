using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EnemyDamage : MonoBehaviour
{
    public int EnemyHealth = 100;
    private Health PlayerHealth;

    private GameObject damVFX;

    private Image damVFXimg;

    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        damVFX = GameObject.FindWithTag("damage");
        damVFXimg = damVFX.GetComponent<Image>();
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
            effectOn();
        }
    }

    private void OnTriggerExit(Collider other) {
        Invoke("effectOff", 2f);
    }
    public void Damage(int damage) 
    {
        PlayerHealth.health -= damage;
    }

    public void effectOn() {
        damVFXimg.enabled = true;
    }

    public void effectOff() {
        damVFXimg.enabled = false;
    }
}
