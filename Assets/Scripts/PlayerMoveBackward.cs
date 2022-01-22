using System.Collections;
using UnityEngine;

public class PlayerMoveBackward : MonoBehaviour
{
    public Material InactiveMaterial;
    public Material GazedAtMaterial;

    private const float _minObjectDistance = 2.5f;
    private const float _maxObjectDistance = 4.0f;
    private const float _minObjectHeight = 0.5f;
    private const float _maxObjectHeight = 3.5f;

    bool gazed;
    int timer;

    private Renderer _myRenderer;
    private Vector3 _startingPosition;

    void Update()
    {
        if(gazed)
        {
            timer++;
        }
        if(timer > 20)
        {
            timer = 0;
            movePlayer();
        }
        
    }

    public void Start()
    {
        _startingPosition = transform.parent.localPosition;
        _myRenderer = GetComponent<Renderer>();
        SetMaterial(false);
    }

    public void movePlayer()
    {
        transform.parent.position = gameObject.transform.parent.position + new Vector3(0, 0, -5);
    }
    public void OnPointerEnter()
    {
        gazed = true;
        SetMaterial(true);
    }
    public void OnPointerExit()
    {
        gazed = false;
        timer = 0;
        SetMaterial(false);
    }

    /// <param name="gazedAt">
    /// Value `true` if this object is being gazed at, `false` otherwise.
    /// </param>
    private void SetMaterial(bool gazedAt)
    {
        if (InactiveMaterial != null && GazedAtMaterial != null)
        {
            _myRenderer.material = gazedAt ? GazedAtMaterial : InactiveMaterial;
        }
    }
}
