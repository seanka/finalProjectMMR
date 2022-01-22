using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gallery_foto : MonoBehaviour
{
    public Texture[] images;
    void Start()
    {
        int ImageIndex = 0; 
        foreach(Transform artwork in transform){
            GameObject art = artwork.Find("Plane").gameObject;
            Renderer rend = artwork.GetComponent<Renderer>();
            Shader shader = Shader.Find("Standard");
            Material mat = new Material(shader);
            mat.mainTexture = images[ImageIndex];
            rend.material = mat;
            ImageIndex++;
            if (ImageIndex == images.Length)ImageIndex=0;


        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
