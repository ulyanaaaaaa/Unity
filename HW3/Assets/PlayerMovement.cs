using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float _speed;
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private Transform _position;
    [SerializeField] private Vector3 _currPlace;

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _rigidbody.velocity = new Vector3(0, 0, _speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            _rigidbody.velocity = new Vector3(0, 0, -_speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            _rigidbody.velocity = new Vector3(_speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            _rigidbody.velocity = new Vector3(-_speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            _rigidbody.velocity = new Vector3(0, _speed, 0);
        }

        _currPlace = new Vector3(_position.position.x, _position.position.y, _position.position.z);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Mass>())
        {
            if (collision.gameObject.GetComponent<Mass>().mas < _rigidbody.mass)  
            {
                Debug.Log("Масса игрока больше!");
                _rigidbody.AddForce(_currPlace * 3, ForceMode.Impulse);
            }
            else
            {
                Debug.Log("Начальная масса врага:" + collision.gameObject.GetComponent<Mass>().mas);
                collision.gameObject.GetComponent<Mass>().mas += _rigidbody.mass;
                collision.gameObject.GetComponent<Mass>().transform.localScale = new Vector3(collision.gameObject.GetComponent<Mass>().mas, collision.gameObject.GetComponent<Mass>().mas, collision.gameObject.GetComponent<Mass>().mas);
                Destroy(_rigidbody.gameObject);
                Debug.Log("Враг съел: " + _rigidbody.mass + " \nМасса врага: " + collision.gameObject.GetComponent<Mass>().mas);
            }
        }
    }
}
