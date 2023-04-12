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

    private Animator playerAnim;

    private bool attack;

    private GameObject AttackHand;

    private GameObject enemyPatrol;

    // Start is called before the first frame update
    void Start()
    {
        damVFX = GameObject.FindWithTag("damage");
        damVFXimg = damVFX.GetComponent<Image>();
        player = GameObject.FindWithTag("Player");
        PlayerHealth = player.GetComponent<Health>();
        playerAnim = player.GetComponent<Animator>();
        attack = playerAnim.GetBool("isWeakAttack");
        AttackHand = GameObject.FindWithTag("AttackHand");
        enemyPatrol = GameObject.FindWithTag("EnemyPatrol");
    }

    // Update is called once per frame
    void Update()
    {
        if (EnemyHealth <= 0)
        {
            Destroy(enemyPatrol);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("AttackHand"))
        {
            takeDMG(10);
            Debug.Log("uh");
        }

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            effectOn();
            Damage(1);
        }

    }


    public void Damage(int damage)
    {
        PlayerHealth.health -= damage;
        Invoke("effectOff", 2f);
    }

    public void takeDMG(int Edamage)
    {
        Debug.Log(EnemyHealth);
        EnemyHealth -= Edamage;
        Debug.Log(EnemyHealth);
    }
    public void effectOn()
    {
        damVFXimg.enabled = true;
    }

    public void effectOff()
    {
        damVFXimg.enabled = false;
    }
}
