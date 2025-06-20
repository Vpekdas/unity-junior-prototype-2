using System;
using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private float _speed;
    private readonly float _xRange = 15.0f;
    private float _horizontalInput;
    private float _verticalInput;
    private int _health;
    private int _score;

    private void Start()
    {
        _health = 3;
        _score = 0;
    }

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

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0, LoadSceneMode.Single);
        }

        if (_health == 0)
        {
            Debug.Log("Game Over !");
        }

    }

    public int GetHealth()
    {
        return _health;
    }

    public int GetScore()
    {
        return _score;
    }

    public void SetHealth(int health)
    {
        if (_health >= 1)
        {
            _health -= health;
        }
    }


    public void SetScore(int score)
    {
        _score += score;
    }

}