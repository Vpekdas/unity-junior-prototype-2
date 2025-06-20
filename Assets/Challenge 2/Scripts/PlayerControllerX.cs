using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
	public GameObject DogPrefab;
	private readonly float _cdr = 2.0f;
	private float _lastPressed = 0.0f;
	private float _currentTime = 0.0f;


	private void Update()
	{
		_currentTime += Time.deltaTime;
		if (Input.GetKeyDown(KeyCode.Space) && _currentTime - _lastPressed >= _cdr)
		{
			_lastPressed = _currentTime;
			Instantiate(DogPrefab, transform.position, DogPrefab.transform.rotation);
		}

	}
}
