using Oculus.Interaction;
using UnityEngine;

public class Level1 : MonoBehaviour
{
    [SerializeField] private Material _successMaterial;
    [SerializeField] private MeshRenderer _meshRenderer;
    [SerializeField] private Grabbable _grabbable;

    public bool IsComplete = false;

    private void Start()
    {
        _grabbable.WhenPointerEventRaised += OnPointerEventRaised;
    }

    private void OnPointerEventRaised(PointerEvent e)
    {
        if (e.Type == PointerEventType.Select)
        {
            _meshRenderer.material = _successMaterial;
            IsComplete = true;
        }
    }
}
