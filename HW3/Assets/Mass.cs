using UnityEngine;

public class Mass : MonoBehaviour
{
    public float mas;
    [SerializeField] public Rigidbody rd;

    private void Start()
    {
        mas = rd.mass;
    }
}
