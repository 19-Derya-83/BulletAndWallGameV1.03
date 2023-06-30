using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoBulletController : MonoBehaviour
{

    [SerializeField] private float _moveSpeed;

    [SerializeField] private float _destroyPoint;

    public GameObject bulletParticle;

    public int damage;

    private Rigidbody _rigidbody;

    public int bulletCount;

    private void Awake()
    {

        _rigidbody = GetComponent<Rigidbody>();

    }


    private void Start()
    {

        MoveWithRigidbody();

    }


    private void Update()
    {

        //Move();
       

        if (transform.position.z >= _destroyPoint)
        {

            Destroy(gameObject);

        }

    }

    public void Move()

    {

        transform.position += Vector3.forward *( Time.deltaTime * _moveSpeed);

    }

    private void MoveWithRigidbody()

    {

        _rigidbody.AddForce(Vector3.forward * _moveSpeed, ForceMode.Impulse);

    }

    public void SelfDestroy()

    {

        Destroy(gameObject, 1f);

    }

    public void ChangeLayer()

    {

        gameObject.layer = LayerMask.NameToLayer("BulletAfterCollision");

    }


}
