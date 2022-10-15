using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{

    public int damageBoss = 10;

    public Vector3 attackOffset;
    public Transform attackPoint;
    public float attackRange = 1f;
    public LayerMask attackMask;

    void Update()
    {
        Collider2D colInfo = Physics2D.OverlapCircle(attackPoint.position, attackRange, attackMask);
        if (colInfo != null)
        {
            colInfo.GetComponent<BossHealth>().TakeDamageBoss(damageBoss);
        }
    }
    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}