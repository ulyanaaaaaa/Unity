using UnityEngine;

public class Mass : MonoBehaviour
{
    public float mas;
    [SerializeField] private Rigidbody _rd;

    private void Start()
    {
        mas = _rd.mass;
    }
}
