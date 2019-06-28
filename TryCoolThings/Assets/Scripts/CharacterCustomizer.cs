using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterCustomizer : MonoBehaviour
{
    public Slider HeadSlider;
    public Slider BodySlider;
    public Slider ArmsSlider;
    public Slider LegsSlider;
    
    public Transform HeadTrans;
    
    public Transform BodyTrans;
    
    public Transform Arms1Trans;
    public Transform Arms2Trans;
    
    public Transform Legs1Trans;
    public Transform Legs2Trans;
    
    public float HeadFloat;
    public float BodyFloat;
    public float ArmsFloat;
    public float LegsFloat;

    private Vector3 HeadTransOrigin;
    private Vector3 BodyTransOrigin;
    private Vector3 ArmsTransOrigin;
    private Vector3 LegsTransOrigin;
    
    private void Start()
    {
        HeadTransOrigin = HeadTrans.localScale;
        BodyTransOrigin = BodyTrans.localScale;
        ArmsTransOrigin = Arms1Trans.localScale;
        LegsTransOrigin = Legs1Trans.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        HeadFloat = HeadSlider.value / 25.0f;
        HeadTrans.localScale = HeadTransOrigin * HeadFloat;

        BodyFloat = BodySlider.value / 25.0f;
        BodyTrans.localScale = BodyTransOrigin * BodyFloat;

        ArmsFloat = ArmsSlider.value / 25.0f;
        Arms1Trans.localScale = ArmsTransOrigin * ArmsFloat;
        Arms2Trans.localScale = ArmsTransOrigin * ArmsFloat;

        LegsFloat = LegsSlider.value / 25.0f;
        Legs1Trans.localScale = LegsTransOrigin * LegsFloat;
        Legs2Trans.localScale = LegsTransOrigin * LegsFloat;
    }
}
