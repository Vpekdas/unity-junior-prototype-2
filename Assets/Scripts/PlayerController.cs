using System;
using UnityEngine;
using UnityEngine.Pool;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed;
    private readonly float _xRange = 15.0f;
    private float _horizontalInput;
    private float _verticalInput;

    void Update()
    {
        if (transform.position.x < -_xRange || transform.position.x > _xRange)
        {
            float adjustedX = transform.position.x < 0.0f ? Math.Abs(_xRange + transform.position.x) : _xRange - transform.position.x;
            transform.position = new Vector3(transform.position.x + adjustedX, transform.position.y, transform.position.z);
        }
        _horizontalInput = Input.GetAxis("Horizontal");
        _verticalInput = Input.GetAxis("Vertical");

        transform.Translate(_verticalInput * _speed * Time.deltaTime * Vector3.forward);
        transform.Translate(_horizontalInput * _speed * Time.deltaTime * Vector3.right);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject pooledProjectile = ObjectPooler.s_SharedInstance.GetPooledObject();
            if (pooledProjectile != null)
            {
                pooledProjectile.SetActive(true);
                pooledProjectile.transform.position = transform.position;
            }
        }

    }
}