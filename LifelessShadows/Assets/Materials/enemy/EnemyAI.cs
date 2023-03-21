using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{


    public float fieldOfViewAngle = 155f;
    public bool playerInSight;
    public Vector3 personalLastSighting;

    public Transform[] patrolRoute;
    public float patrolSpeed = 1.5f;
    public float idleTime = 2f;

    private NavMeshAgent nav;
    private CapsuleCollider col;
    private Animator anim;
    private GameObject player;

    private Light flashL;
    private GameObject flash;
    private Vector3 previousSighting;

    private int currentPatrolIndex = 0;
    private float idleTimer = 0f;

    void Awake()
    {
        nav = GetComponent<NavMeshAgent>();
        col = GetComponent<CapsuleCollider>();
        anim = GetComponent<Animator>();
        player = GameObject.FindWithTag("Player");
        flash = GameObject.FindWithTag("FlashLight");
        flashL = flash.GetComponent<Light>();
        previousSighting = Vector3.zero;
        personalLastSighting = Vector3.zero;
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject == player)
        {
            playerInSight = false;

            Vector3 direction = other.transform.position - transform.position;
            float angle = Vector3.Angle(direction, transform.forward);

            if (angle < fieldOfViewAngle * 0.5f)
            {
                RaycastHit hit;

                if (Physics.Raycast(transform.position + transform.up, direction.normalized, out hit, col.radius))
                {
                    if (hit.collider.gameObject == player)
                    {
                        playerInSight = true;
                        personalLastSighting = player.transform.position;
                    }
                }
            }
        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
        {
            playerInSight = false;
        }
    }

    void Update()
    {
        if (playerInSight)
        {
            nav.destination = player.transform.position;
        }
        else
        {
            if (patrolRoute.Length > 0)
            {
                if (idleTimer > 0f)
                {
                    idleTimer -= Time.deltaTime;
                    return;
                }
                
                if (nav.remainingDistance <= nav.stoppingDistance)
                {
                    currentPatrolIndex = (currentPatrolIndex + 1) % patrolRoute.Length;
                    idleTimer = idleTime;
                }

                nav.destination = patrolRoute[currentPatrolIndex].position;
                nav.speed = patrolSpeed;
            }
        }
        if (flashL.enabled == true) {
            fieldOfViewAngle = 360f;
        }
        else 
        {
            fieldOfViewAngle = 155f;
        }

    }
}

