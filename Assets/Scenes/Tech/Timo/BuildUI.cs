using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildUI : MonoBehaviour {
  [SerializeField] private ComboStatsSO _comboStats;
  [SerializeField] private Image[] _barImages;

  private void Start() {
    Debug.Log("Building UI");
    Vector2 widthGreen = _barImages[2].rectTransform.sizeDelta = new Vector2(_comboStats.phaseThree * 500, 100);

    Vector2 widthYellow =_barImages[1].rectTransform.sizeDelta = new Vector2(_comboStats.phaseTwo * 500, 100);
    Vector3 rectTransformPositionY1 = _barImages[1].rectTransform.localPosition;
    rectTransformPositionY1.x = -(widthGreen.x / 2 + widthYellow.x / 2);
    _barImages[1].rectTransform.localPosition = rectTransformPositionY1;
      
    _barImages[3].rectTransform.sizeDelta = new Vector2(_comboStats.phaseFour * 500, 100);
    Vector3 rectTransformPositionY2 = _barImages[3].rectTransform.localPosition;
    rectTransformPositionY2.x = widthGreen.x / 2 + widthYellow.x / 2;
    _barImages[3].rectTransform.localPosition = rectTransformPositionY2;
    
    Vector2 widthRed = _barImages[0].rectTransform.sizeDelta = new Vector2(_comboStats.phaseOne * 500, 100);
    Vector3 rectTransformPositionR1 = _barImages[0].rectTransform.localPosition;
    rectTransformPositionR1.x = -(widthGreen.x / 2+ widthYellow.x + widthRed.x / 2);
    _barImages[0].rectTransform.localPosition = rectTransformPositionR1;

    _barImages[4].rectTransform.sizeDelta = new Vector2(_comboStats.phaseOne * 500, 100);
    Vector3 rectTransformPositionR2 = _barImages[4].rectTransform.localPosition;
    rectTransformPositionR2.x = widthGreen.x / 2+ widthYellow.x + widthRed.x / 2;
    _barImages[4].rectTransform.localPosition = rectTransformPositionR2;
  }
}
