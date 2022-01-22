using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonjaliScript : MonoBehaviour
{
    public Material InactiveMaterial;
    public Material GazedAtMaterial;

    private Renderer _myRenderer;
    private Vector3 _startingPosition;

    public GameObject Canvas;
    public ObjectManager om;
    private const float _minObjectDistance = 2.5f;
    private const float _maxObjectDistance = 4.0f;
    private const float _minObjectHeight = 0.5f;
    private const float _maxObjectHeight = 3.5f;

    bool gazed;
    bool gazed2;
    int timer;
    int timer2;

    void Update()
    {
        if(gazed)
        {
            timer++;
        }
        if(timer > 25)
        {
            timer = 0;
            om.Play(4);
        }

        if(gazed2)
        {
            timer2++;
        }
        if(timer2 > 25)
        {
            timer2 = -3000;
            om.PlaySound(4);
        }
    }

    public void Start()
    {
        _startingPosition = transform.parent.localPosition;
        _myRenderer = GetComponent<Renderer>();
        GetComponent<Renderer>().enabled = false;
        SetMaterial(false);
    }
    public void OnPointerEnter()
    {
        gazed = true;
        gazed2 = true;
        SetMaterial(true);
    }
    public void OnPointerExit()
    {
        gazed = false;
        gazed2 = false;
        timer = 0;
        timer2 = 0;
        SetMaterial(false);
        Canvas.SetActive(false);
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
