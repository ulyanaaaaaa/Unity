using UnityEngine;

public class MassChange : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;

    void Start()
    {   
        OnScaleEvent(_rigidbody.mass);
    }

    void OnScaleEvent(float scale)
    {
        transform.localScale = new Vector3(scale, scale, scale);
    }

}
