using UnityEngine;

public class Level2 : MonoBehaviour
{
    [SerializeField] private Material _successMaterial;
    [SerializeField] private MeshRenderer _meshRenderer;
    [SerializeField] private GameObject _cube;
    
    public bool IsComplete;
    
    private void OnTriggerEnter(Collider other)
    {
        if (_cube == other.transform.gameObject)
        {
            _meshRenderer.material = _successMaterial;
            IsComplete = true;
        }
    }
}
