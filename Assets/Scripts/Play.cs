using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class Play : MonoBehaviour
{
    public Button clicker;
    public VideoPlayer vPlayer;
    public Image iPlay;
    public Sprite sPlay;
    public Sprite sPause;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        clicker.GetComponent<Button>().onClick.AddListener(onClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (vPlayer.isPlaying)
        {
            Color c = iPlay.color;
            c.a -= (float)0.02;
            iPlay.color = c;
        }
    }

    void onClick()
    {
        if (!vPlayer.isPlaying)
        {
            vPlayer.Play();
            iPlay.sprite = sPlay;
        }
        else
        {
            vPlayer.Pause();
            iPlay.sprite = sPause;
        }
        iPlay.color = Color.white;
    }
}
