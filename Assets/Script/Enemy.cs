using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Collider2D))]
public abstract class Enemy : MonoBehaviour
{

    protected Rigidbody2D body;
    protected GameObject player;
    protected Animator animator;

    protected bool hitting = false;
    public int hp = 100;
    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void Start()
    {
        player = GameManager.Instance.player;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Attack")) return;
        hitting = true;
    }

    public abstract INode SetTree();
}
