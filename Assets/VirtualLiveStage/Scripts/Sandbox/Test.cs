using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Zenject;


namespace VLS
{
    public class Test : MonoBehaviour
    {

        [Inject] SampleSO _so;

        // Start is called before the first frame update
        void Start()
        {
            Debug.Log(_so.GetType());
            Debug.Log(_so.Name);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}
