using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Timeline;
using UnityEngine.Playables;

public class StopTimeline : MonoBehaviour
{

    Button btnStopTimeline;

    [SerializeField]
    PlayableDirector playableDirector;

    void Awake()
    {
    

        btnStopTimeline = GetComponent<Button>();
        btnStopTimeline.onClick.AddListener(ButtonStopTimeline);

    }




    void ButtonStopTimeline()
    {
        playableDirector.Stop();
    }

}
