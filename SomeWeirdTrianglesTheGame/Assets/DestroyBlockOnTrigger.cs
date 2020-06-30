using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBlockOnTrigger : MonoBehaviour
{
    public ParticleSystem exp;
    public SpriteRenderer graphics;
    public Collider2D col;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            graphics.enabled = false;
            col.enabled = false;
            Destroy(collision.gameObject);
            exp.Play();
            Destroy(gameObject, exp.main.duration);
        }
    }
}
