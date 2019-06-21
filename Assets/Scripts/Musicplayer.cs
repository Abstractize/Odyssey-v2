using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Musicplayer : MonoBehaviour
{
    bool play = false;
    public Queue<AudioClip> songs = new Queue<AudioClip>();
    private AudioSource player;
    public Button forward;
    public Button back;
    public Button playB;
    public Sprite playI;
    public Sprite pause;
    public string URL = "D:\\Users\\Gabo\\Music\\A Perfect Circle\\a perfect circle 01 - hollow.mp3";

    private void OnEnable()
    {
        playB.onClick.AddListener(playMusic);
    }
    private void Awake()
    {
        player = GetComponent<AudioSource>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void playMusic()
    {
        Debug.Log(play);
        switch (play)
        {
            //No Reproducir
            case true:
                playB.image.sprite = playI;
                play = false;
                player.Pause();
                break;
            //Reproducir
            case false:
                playB.image.sprite = pause;
                play = true;
                player.Play();
                break;
            
        }
        Debug.Log("switch:"+play);
    }
    public bool Play { get => play; set => play = value; }
}
