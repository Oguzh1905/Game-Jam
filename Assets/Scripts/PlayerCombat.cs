using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{

    public Animator animator;
    
    public Transform attackpoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;
<<<<<<< HEAD
<<<<<<< main
    public float attackRate = 4f;
    float nextAttackTime = 0f;
    public int attackDamage = 40;
    // Update is called once per frame
    void Update()
    {
        if(Time.time >= nextAttackTime)
=======
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
>>>>>>> Knight
=======
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
>>>>>>> Stephan
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                Attack();
                nextAttackTime = Time.time + 1f / attackRate;
            }
        }
    }
    void Attack()
    {
        //player attack animation
        animator.SetTrigger("Attack");
        //enemies in range
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackpoint.position, attackRange, enemyLayers);
        //damage them
        foreach(Collider2D enemy in hitEnemies)
        {
<<<<<<< HEAD
<<<<<<< main
            enemy.GetComponent<Enemy>().TakeDamage(attackDamage);
=======
            Debug.Log("We hit " + enemy.name);
>>>>>>> Knight
=======
            Debug.Log("We hit " + enemy.name);
>>>>>>> Stephan
        }
    }
    private void OnDrawGizmosSelected()
    {
        if (attackpoint == null)
            return;

        Gizmos.DrawWireSphere(attackpoint.position, attackRange);
    }

}
