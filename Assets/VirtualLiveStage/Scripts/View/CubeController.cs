using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace VLS.View
{
    public class CubeController : MonoBehaviour
    {
        public void ChangeScale(float scale = 2f)
        {
            transform.localScale *= scale;
        }
    }
}
