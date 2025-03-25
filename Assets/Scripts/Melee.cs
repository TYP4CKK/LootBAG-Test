using UnityEngine;

public class MeleeAttack : MonoBehaviour
{
    public bool meleeCondition = false;
    private Animator animator;
    void Start()
    {
    animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            meleeCondition = true;
            Debug.Log("Melee mode activated!");
        }

        if (Input.GetKeyUp(KeyCode.E))
        {
            meleeCondition = false;
            Debug.Log("Melee mode deactivated!");
        }
        animator.SetBool("meleeCondition", meleeCondition);
    }
}
