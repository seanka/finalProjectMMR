using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OC_Batik : MonoBehaviour
{
 public Material InactiveMaterial;
    private Renderer _myRenderer;
    public Material GazedAtMaterial;
    public SoundManager sm;
    // Start is called before the first frame update
    bool gazed;
    int timer;
    void Start()
    {
        timer = 0;
        SetMaterial(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gazed)
        {
            timer++;   
        }
        if (timer > 30)
        {
            timer = 0;
            SoundManager.sm.Play(3);
            Debug.Log("sudah berhasil");
        }
    }

    public void OnPointerEnter()
    {
        SetMaterial(true);
        gazed = true;
    }

    public void OnPointerExit()
    {
        SetMaterial(false);
        gazed = false;
        timer = 0;
    }
    public void OnPointerClick()
    {
        // TeleportRandomly();
    }
    private void SetMaterial(bool gazedAt)
    {
        if (InactiveMaterial != null && GazedAtMaterial != null)
        {
            _myRenderer.material = gazedAt ? GazedAtMaterial : InactiveMaterial;
        }
    }
}
