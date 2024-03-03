using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MegaCode : MonoBehaviour
{
    //Sliders
    [SerializeField] private Slider _autoSpeakerSlider;
    [SerializeField] private Slider _teleSpeakerSlider;
    [SerializeField] private Slider _autoAmpSlider;
    [SerializeField] private Slider _teleAmpSlider;

    //Texts
    [SerializeField] private TextMeshProUGUI _autoSpeakerText;
    [SerializeField] private TextMeshProUGUI _teleSpeakerText;
    [SerializeField] private TextMeshProUGUI _autoAmpText;
    [SerializeField] private TextMeshProUGUI _teleAmpText;
    
    //objects
    private object aS;
    private object tS;
    private object aA;
    private object tA;

    // Start is called before the first frame update
    void Start()
    {
        //Change text values
        _autoSpeakerSlider.onValueChanged.AddListener((aS) => {
            _autoSpeakerText.text = aS.ToString("0");
        });
        _teleSpeakerSlider.onValueChanged.AddListener((tS) => {
            _teleSpeakerText.text = tS.ToString("0");
        });
        _autoAmpSlider.onValueChanged.AddListener((aA) => {
            _autoAmpText.text = aA.ToString("0");
        });
        _teleAmpSlider.onValueChanged.AddListener((tA) => {
            _teleAmpText.text = tA.ToString("0");
        });
    }

    // Update is called once per frame
    void Update()
    {

    }
}
