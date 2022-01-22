using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    
    public List<AudioClip> Clips;

    public AudioSource source;
    

    public static SoundManager sm;
    // Start is called before the first frame update
    void Awake(){
        if(sm==null){
            sm = this;
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    // public void berhenti(){
    //     source.Pause();
    // }
    int temp = -1;

    public void Play(int clipNum) {
        
        if(clipNum == temp){
            return;
        }
        else{
            source.clip = Clips[clipNum];
            source.Play();
            // source.Play(Clips[clipNum]);
        }
        temp = clipNum;
    }

}
