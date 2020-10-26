using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;


[CreateAssetMenu]
public class FloatData : ScriptableObject
{
        public float value;
        public UnityEvent lessThanZeroEvent;

        public void SetValue(float number)
        {
                value = number;
        }

        public void UpdateValue(float number)
        {
                value += number;
        }

        public void SetImageFillAmount(Image img)
        {
                if(value >= 0 || value <= 1)
                {
                        img.fillAmount = value;
                }

                if(value <= 0)
                {
                        lessThanZeroEvent.Invoke();
                        value = 0;
                }

                if(value >= 1)
                {
                        value = 1;
                }
        }

        public void ResetValue(float number)
        {
                value = number;

        }

}
