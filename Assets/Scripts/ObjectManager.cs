using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectManager : MonoBehaviour
{
    public Text Title;
    public Text Description;
    public GameObject Canvas;
    public List<AudioClip> SoundClips;
    public AudioSource AudioSource;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play(int objectNumber)
    {
        if(objectNumber == 1) //Keratonan jogja
        {
            Title.text = "Keratonan" + "\n" + "Yogyakarta";
            Description.text = "Istana resmi Kesultanan Nyayogyakarta Hadiningrat yang berlokasi di pusat Daerah Istimewa Yogyakarta yang memiliki luas 14.000 meter persegi."
            + " Resmi dinyatakan sebagai Kawasan Cagar Budaya berdasarkan SK Gubernur no.186/2011";
            
        }

        else if(objectNumber == 2) //Tugu jogja
        {
            Title.text = "Tugu" + "\n" + "Yogyakarta";
            Description.text = "Salah satu ikon di kota Yogyakarta yang awalnya dikenal dengan \"Tugu Golong Gilig\","
            + " dan sekarang dikenal dengan nama \"Tugu Pal Putih\" karena tugu ini berwarna putih. Tugu ini merupakan garis bersifat magis yang"
            + " menghubungkan Laut Selatan, Keraton Yogyakarta, dan Gunung Merapi";
        }

        else if(objectNumber == 3) //becak
        {
            Title.text = "Becak" + "\n" + "Yogyakarta";
            Description.text = "Becak mengalami masa jaya mulai tahun 1950-an, dan berkembang pesat pada era 1970-an yang digunakan sebagai"
            + " alat transportasi";        
        }

        else if(objectNumber == 4) //monjali
        {
            Title.text = "Monumen" + "\n" + "Jogja Kembali";
            Description.text = "Didirikan untuk memperingati peristiwa berfungsinya kembali Kota Yogyakarta sebagai Ibu Kota republik Infonesia"
            + "yang direbut dari penjah Belandan pada 29 Juni 1949. Monumen ini dibangun pada 29 Juni 1985 dengan lahan seluas 49.920 m2 dengan"
            + "ketinggian 31.8 meter";
        }

        else if(objectNumber == 5) //manusia
        {
            Title.text = " ";
            Description.text = "Memasuki gedung keratonan yogyakarta";
        }

        Canvas.SetActive(true);
    }

    public void PlaySound(int objectNumber)
    {
        AudioSource.clip = SoundClips[objectNumber-1];
        AudioSource.Play();
    }
}
