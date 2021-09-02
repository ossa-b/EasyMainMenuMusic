using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Music : MonoBehaviour
{
    //Texts
    public Text SongTitle;
    public Text SongArtist;

    //Audio clips
    public AudioClip LeanOn;
    public AudioClip Silhouette;
    public AudioClip AreWeStillYoung;
    public AudioClip ThisGirl;
    public AudioClip Flight;
    public AudioClip Eternal;
    public AudioClip FlipReset;

    //Config
    string LeanOnName = "Lean On";
    string SilhouetteName = "Silhouette (Feed Me Remix)";
    string AreWeStillYoungName = "Are We Still Young";
    string ThisGirlName ="This Girl";
    string FlightName = "Flight";
    string EternalName = "Eternal";
    string FlipResetName = "Flip Reset";

    string LeanOnArtist = "Major Lazer & Dj Snake (feat. MØ)";
    string SilhouetteArtist = "Bad Computer, Skyelle, Feed Me";
    string AreWeStillYoungArtist = "Grant, Juneau";
    string ThisGirlArtist ="Kungs, Cookin’ on 3 Burners";
    string FlightArtist = "Tristam, Braken";
    string EternalArtist = "Athena, smle";
    string FlipResetArtist = "Kaskade, WILL K";

    System.Random random = new System.Random();

    /*
    1 = Lean On
    2 = Silhouette
    3 = Are We Still Young
    4 = ThisGirl
    5 = Flight
    6 = Eternal
    7 = Flip Reset
    */

    void Start()
    {
        AudioSource song = GetComponent<AudioSource>();

        int songtp = random.Next(1,8);
        if(songtp == 1)
        {
            song.clip = LeanOn;
            SongTitle.text = LeanOnName;
            SongArtist.text = LeanOnArtist;
        }
        if(songtp == 2)
        {
            song.clip = Silhouette;
            SongTitle.text = SilhouetteName;
            SongArtist.text = SilhouetteArtist;
        }
        if(songtp == 3)
        {
            song.clip = AreWeStillYoung;
            SongTitle.text = AreWeStillYoungName;
            SongArtist.text = AreWeStillYoungArtist;
        }
        if(songtp == 4)
        {
            song.clip = ThisGirl;
            SongTitle.text = ThisGirlName;
            SongArtist.text = ThisGirlArtist;
        }
        if(songtp == 5)
        {
            song.clip = Flight;
            SongTitle.text = FlightName;
            SongArtist.text = FlightArtist;
        }
        if(songtp == 6)
        {
            song.clip = Eternal;
            SongTitle.text = EternalName;
            SongArtist.text = EternalArtist;
        }
        if(songtp == 7)
        {
            song.clip = FlipReset;
            SongTitle.text = FlipResetName;
            SongArtist.text = FlipResetArtist;
        }
        song.Play();
    }

    void Update()
    {
        AudioSource song = GetComponent<AudioSource>();
        if(!song.isPlaying)
        {
        int songtp = random.Next(1,8);
        if(songtp == 1)
        {
            song.clip = LeanOn;
            SongTitle.text = LeanOnName;
            SongArtist.text = LeanOnArtist;
        }
        if(songtp == 2)
        {
            song.clip = Silhouette;
            SongTitle.text = SilhouetteName;
            SongArtist.text = SilhouetteArtist;
        }
        if(songtp == 3)
        {
            song.clip = AreWeStillYoung;
            SongTitle.text = AreWeStillYoungName;
            SongArtist.text = AreWeStillYoungArtist;
        }
        if(songtp == 4)
        {
            song.clip = ThisGirl;
            SongTitle.text = ThisGirlName;
            SongArtist.text = ThisGirlArtist;
        }
        if(songtp == 5)
        {
            song.clip = Flight;
            SongTitle.text = FlightName;
            SongArtist.text = FlightArtist;
        }
        if(songtp == 6)
        {
            song.clip = Eternal;
            SongTitle.text = EternalName;
            SongArtist.text = EternalArtist;
        }
        if(songtp == 7)
        {
            song.clip = FlipReset;
            SongTitle.text = FlipResetName;
            SongArtist.text = FlipResetArtist;
        }
        song.Play(); 
        }

        if(Input.GetKeyDown(KeyCode.N))
        {
                    int songtp = random.Next(1,8);
        if(songtp == 1)
        {
            song.clip = LeanOn;
            SongTitle.text = LeanOnName;
            SongArtist.text = LeanOnArtist;
        }
        if(songtp == 2)
        {
            song.clip = Silhouette;
            SongTitle.text = SilhouetteName;
            SongArtist.text = SilhouetteArtist;
        }
        if(songtp == 3)
        {
            song.clip = AreWeStillYoung;
            SongTitle.text = AreWeStillYoungName;
            SongArtist.text = AreWeStillYoungArtist;
        }
        if(songtp == 4)
        {
            song.clip = ThisGirl;
            SongTitle.text = ThisGirlName;
            SongArtist.text = ThisGirlArtist;
        }
        if(songtp == 5)
        {
            song.clip = Flight;
            SongTitle.text = FlightName;
            SongArtist.text = FlightArtist;
        }
        if(songtp == 6)
        {
            song.clip = Eternal;
            SongTitle.text = EternalName;
            SongArtist.text = EternalArtist;
        }
        if(songtp == 7)
        {
            song.clip = FlipReset;
            SongTitle.text = FlipResetName;
            SongArtist.text = FlipResetArtist;
        }
        song.Play(); 
        }
    }
}
