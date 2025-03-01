using UnityEngine;

public class audioScript : MonoBehaviour
{
    public AudioClip flapSound;
    public AudioClip hitPipeSound;
    public AudioClip scoreSound;
    public AudioClip music;
    public AudioSource flapSrc;
    public AudioSource hitPipeSrc;
    public AudioSource scoreSrc;
    public AudioSource musicSrc;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void flapSoundPlayer() {
        flapSrc.clip = flapSound;
        flapSrc.Play();
    }

    public void hitPipeSoundPlayer() {
        hitPipeSrc.clip = hitPipeSound;
        hitPipeSrc.Play();
    }

    public void scoreSoundPlayer() {
        scoreSrc.clip = scoreSound;
        scoreSrc.Play();
    }

    public void musicPlayer() {
        musicSrc.clip = music;
        musicSrc.Play();
    }

    private void Start() {
        //musicPlayer();
    }

}
