using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
	protected Animator anim;
	protected Rigidbody2D rb;
	protected AudioSource death;

	protected virtual void Start()
	{
		anim = GetComponent<Animator>();
		rb = GetComponent<Rigidbody2D>();
		death = GetComponent<AudioSource>();
	}
	
	public void JumpedOn()
	{
		anim.SetTrigger("Death");
		death.Play();
		rb.velocity = Vector2.zero;
		rb.bodyType = RigidbodyType2D.Kinematic;
		GetComponent<Collider2D>().enabled = false;
	}

	private void Death()
	{
		Destroy(this.gameObject);
	}
}