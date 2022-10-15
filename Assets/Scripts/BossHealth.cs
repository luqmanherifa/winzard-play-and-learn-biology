using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealth : MonoBehaviour
{
    public int maxHealth = 1000;
    public int currentHealthBoss;
    public HealthBarBoss healthBarBoss;
    private Animator anim;
    private bool Die;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        Die = false;
        currentHealthBoss = maxHealth;
        healthBarBoss.SetMaxHealthBoss(maxHealth);
    }

    public void TakeDamageBoss(int damageBoss)
    {
        currentHealthBoss -= damageBoss;
        healthBarBoss.SetHealthBoss(currentHealthBoss);
        /*StartCoroutine(DamageAnimation());*/
        if (currentHealthBoss <= 0)
        {
            anim.SetBool("Die", true);
        }
    }

    /*IEnumerator DamageAnimation()
    {
        SpriteRenderer[] srs = GetComponentInChildren<SpriteRenderer>();
        for (int i = 0; i < 3; i++)
        {
            foreach (SpriteRenderer sr in srs)
            {
                Color c = sr.color;
                c.a = 0;
                sr.color = c;
            }
            yield return new WaitForSeconds(.1f);

            foreach (SpriteRenderer sr in srs)
            {
                Color c = sr.color;
                c.a = 1;
                sr.color = c;
            }
            yield return new WaitForSeconds(.1f);
        }
    }*/
}
