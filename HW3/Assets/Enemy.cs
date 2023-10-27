using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Vector3 _position;
    [SerializeField] private Transform _transform;

    public Vector3 getPosition()
    {
        return _position = new Vector3(_transform.position.x, _transform.position.y, _transform.position.z);
    }
}
