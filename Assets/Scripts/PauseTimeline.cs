using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Timeline;
using UnityEngine.Playables;

public class PauseTimeline : MonoBehaviour
{
    Button btnPauseTimeline;

    static bool pause = false;

    [SerializeField]
    PlayableDirector playableDirector;

    void Awake()
    {
      
        btnPauseTimeline = GetComponent<Button>();
        btnPauseTimeline.onClick.AddListener(ButtonPauseTimeline);


    }



    void ButtonPauseTimeline()
    {

        playableDirector.Pause();
        pause = true;
    }

 

}