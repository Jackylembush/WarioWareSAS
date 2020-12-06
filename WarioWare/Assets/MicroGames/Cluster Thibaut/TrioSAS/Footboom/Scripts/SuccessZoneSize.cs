using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TrioSAS
{
    namespace Footboom
    {
        /// <summary>
        /// Steve Guitton
        /// </summary>
        
        public class SuccessZoneSize : MonoBehaviour
        {
            public RectTransform rectTransform;
            public float heightModifier;

            void Start()
            {
                rectTransform = GetComponent<RectTransform>();
                rectTransform.sizeDelta = new Vector2(rectTransform.sizeDelta.x, rectTransform.sizeDelta.y* heightModifier);
            }
        }
    }
}
