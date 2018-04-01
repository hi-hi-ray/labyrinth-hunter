using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    public AudioSource sound1mino;
    public AudioSource sound2mino;
    public AudioSource sound3mino;
    public AudioSource sound4mino;

    public void PlayMinoSFX1() {
        sound1mino.Play();
    }
    public void PlayMinoSFX2() {
        sound2mino.Play();
    }
    public void PlayMinoSFX3() {
        sound3mino.Play();
    }
    public void PlayMinoSFX4() {
        sound4mino.Play();
    }

}