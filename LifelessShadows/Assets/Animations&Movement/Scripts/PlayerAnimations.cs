using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    Animator animator;

    public AudioSource source;
    public AudioClip walking1;

    int isWalkingHash;
    int isStrafeRHash;
    int isStrafeLHash;
    int isBackHash;
    int isRunHash;

    int isCrouchHash;

    int isCrouchStandingHash;

    int isWeakAttackHash; 
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("isWalking");
        isBackHash = Animator.StringToHash("isBack");
        isStrafeRHash = Animator.StringToHash("isStrafeR");
        isStrafeLHash = Animator.StringToHash("isStrafeL");
        isRunHash = Animator.StringToHash("isRun");
        isCrouchHash = Animator.StringToHash("isCrouch");
        isCrouchStandingHash = Animator.StringToHash("isStanding");
        isWeakAttackHash = Animator.StringToHash("isWeakAttack");

    }

    // Update is called once per frame
    void Update()
    {

        bool isWalking = animator.GetBool(isWalkingHash);
        bool isBack = animator.GetBool(isBackHash);
        bool isStrafeR = animator.GetBool(isStrafeRHash);
        bool isStrafeL = animator.GetBool(isStrafeLHash);
        bool isRun = animator.GetBool(isRunHash);
        bool isCrouch = animator.GetBool(isCrouchHash);
        bool isStanding = animator.GetBool(isCrouchStandingHash);
        bool isWeakAttack = animator.GetBool(isWeakAttackHash);
        bool forwardPressed = Input.GetKey("w");
        bool runPressed = Input.GetKey(KeyCode.LeftShift);
        bool backPressed = Input.GetKey("s");
        bool leftPressed = Input.GetKey("a");
        bool rightPressed = Input.GetKey("d");
        bool crouchPresssed = Input.GetKey(KeyCode.LeftControl);
        bool weakAttackPressed = Input.GetMouseButtonDown(0);



        if (!isWalking && forwardPressed)
        {
            animator.SetBool("isWalking", true);
            FindObjectOfType<AudioManager>().Play("Walking");
        }
        if (isWalking && !forwardPressed)
        {
            animator.SetBool("isWalking", false);
        }

        if (!isBack && backPressed)
        {
            animator.SetBool("isBack", true);
            FindObjectOfType<AudioManager>().Play("Walking");
        }
        if (isBack && !backPressed)
        {
            animator.SetBool("isBack", false);
        }
         
        if (runPressed && forwardPressed)
        {
            animator.SetBool("isRun", true);
        }
        if (!forwardPressed || !runPressed)
        {
            animator.SetBool("isRun", false);
        }
        if (runPressed && backPressed)
        {
            animator.SetBool("isBackRun", true);
        }
        if (!backPressed || !runPressed)
        {
            animator.SetBool("isBackRun", false);
        }
        if (!isStrafeR && rightPressed)
        {
            animator.SetBool("isStrafeR", true);
            FindObjectOfType<AudioManager>().Play("Walking");
        }
        if (isStrafeR && !rightPressed)
        {
            animator.SetBool("isStrafeR", false);
        }
        if (!isStrafeL && leftPressed)
        {
            animator.SetBool("isStrafeL", true);
            FindObjectOfType<AudioManager>().Play("Walking");
        }
        if (isStrafeL && !leftPressed)
        {
            animator.SetBool("isStrafeL", false);
        }
        if (!isWeakAttack && weakAttackPressed) 
        {
            animator.SetBool("isWeakAttack", true);
            Invoke("stopAttack", 0.41f);
        }

    }

    public void stopAttack() {
        animator.SetBool("isWeakAttack",false);
    }
}
