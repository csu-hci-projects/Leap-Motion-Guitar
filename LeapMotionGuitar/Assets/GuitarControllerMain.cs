using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuitarControllerMain : MonoBehaviour
{
    public AudioSource guitarAudioSource;
    public AudioClip[] chords;
    public Text chordInfo;

    int chordNumber = 0; // produces the open (no chord) guitar sound
    public void setChordNumber(int chordNumber) {
        this.chordNumber = chordNumber;
        Debug.Log("Chord Number set to " + chordNumber);
        setChordInfo();
    }

    public void setChordInfo() {
        chordInfo.text = "Chord Number: " + chordNumber;
        string chordName = "Open(None)";
        switch (chordNumber) {
            case 1:
                chordName = "C"; break;
            case 2:
                chordName = "Dm"; break;
            case 3:
                chordName = "Em"; break;
            case 4:
                chordName = "F"; break;
            case 5:
                chordName = "G"; break;
        }
        chordInfo.text += "\n" + chordName;
    }

    public void strumGuitarStrings() {
        guitarAudioSource.Stop();
        guitarAudioSource.clip = chords[chordNumber];
        guitarAudioSource.Play();
    }
}
