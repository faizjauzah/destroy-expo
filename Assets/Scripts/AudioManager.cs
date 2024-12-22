using UnityEngine;
using UnityEngine.UIElements;

public class audioManager : MonoBehaviour
{
    [Header("====== Audio Source ======")]
    [SerializeField] AudioSource musicSource;

    [Header("====== Audio Clip ======")]
    public AudioClip bg;

    private void start(){
        musicSource.clip = bg;
        musicSource.loop = true;
        musicSource.Play();
    }

}
