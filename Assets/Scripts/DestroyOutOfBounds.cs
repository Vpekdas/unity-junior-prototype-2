using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    private readonly float _topBound = 30;
    private readonly float _rightBound = 20;

    private readonly float _lowerBound = -10;
    private int _playerHealth;
    private GameObject _player;
    private PlayerController _playerController;

    private void Start()
    {
        _player = GameObject.Find("Player");
        _playerController = _player.GetComponent<PlayerController>();

    }

    void Update()
    {
        if (transform.position.z > _topBound)
        {
            gameObject.SetActive(false);
        }
        else if (transform.position.z < _lowerBound && gameObject.CompareTag("Animal"))
        {
            Destroy(gameObject);
            _playerController.SetHealth(1);
            Debug.Log("Lives = " + _playerController.GetHealth());

        }
        else if ((transform.position.x > _rightBound || transform.position.x < -_rightBound) && gameObject.CompareTag("Animal"))
        {
            Destroy(gameObject);
            _playerController.SetHealth(1);
            Debug.Log("Lives = " + _playerController.GetHealth());
        }
    }
}