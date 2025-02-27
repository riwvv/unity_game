using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class movement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;

    private Vector3 _input;
    private bool _IsMoving;
    public bool OnGround;
    public Transform GroundCheck;
    public float checkRadius = 0.5f;
    public LayerMask Ground;

    [SerializeField] private SpriteRenderer _playerSprite;
    private Rigidbody2D _rb;
    private moveAnimatoin _animattions;

    private void Start(){
        _rb = GetComponent<Rigidbody2D>();
        _animattions = GetComponentInChildren<moveAnimatoin>();
    }

    private void Update() {
        Move();
        CheckingGround();
        if (Input.GetKeyDown(KeyCode.Space) && OnGround){
            Jump();
        }
    }

    private void Move(){
        _input = new Vector2(Input.GetAxis("Horizontal"), 0);
        transform.position += _input * _speed * Time.deltaTime;
        _IsMoving = _input.x != 0 ? true : false;

        if (_input.x != 0) {
            _playerSprite.flipX = _input.x > 0 ? false : true;
        }
        _animattions.IsMoving = _IsMoving;
    }

    private void Jump(){
        _rb.AddForce(transform.up * _jumpForce);
    }

    void CheckingGround(){
        OnGround = Physics2D.OverlapCircle(GroundCheck.position, checkRadius, Ground);
    }
}