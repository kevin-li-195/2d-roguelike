using UnityEngine;
using System.Collections;

public abstract class MovingObject : MonoBehaviour {
    
    public float moveTime = 0.1f;
    public LayerMask blockingLayer;

    private BoxCollider2D boxCollider;
    private Rigidbody2D rb2d;
    private float inverseMoveTime;

	private protected void Start () {
	
	}
	
	void Update () {
	
	}
}
