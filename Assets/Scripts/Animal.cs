using UnityEngine;

public class Animal : MonoBehaviour
{
    public float Health;
    public float MaxHealth;
    private GameObject _player;
    private PlayerController _playerController;


    [SerializeField] FloatingHealthBar _healthBar;

    private void Awake()
    {
        _healthBar = GetComponentInChildren<FloatingHealthBar>();
    }

    private void Start()
    {
        Health = MaxHealth;
        _healthBar.UpdateHealth(Health, MaxHealth);
        _player = GameObject.Find("Player");
        _playerController = _player.GetComponent<PlayerController>();
    }


    public void TakeDamage()
    {
        Health -= 25;
        _healthBar.UpdateHealth(Health, MaxHealth);
    }

    private void Update()
    {
        if (Health <= 0)
        {
            gameObject.SetActive(false);
            _player.GetComponent<PlayerController>().SetScore(1);
            Debug.Log("Score = " + _playerController.GetScore());
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Projectile"))
        {
            TakeDamage();
        }
    }
}