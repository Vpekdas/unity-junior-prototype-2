using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float Speed;

    void Update()
    {
        transform.Translate(Speed * Time.deltaTime * Vector3.forward);
    }
}