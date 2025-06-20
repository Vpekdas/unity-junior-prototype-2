using UnityEngine;

public class Animal : MonoBehaviour
{
    public float Health;
    public float MaxHealth;
    [SerializeField] FloatingHealthBar _healthBar;

    private void Awake()
    {
        _healthBar = GetComponentInChildren<FloatingHealthBar>();
    }

    private void Start()
    {
        Health = MaxHealth;
        _healthBar.UpdateHealth(Health, MaxHealth);
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