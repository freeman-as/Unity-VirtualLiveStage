using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UniRx;

namespace VLS.Model
{
    public class MainSceneModel
    {
        private readonly IReactiveProperty<float> _sampleSingle = new ReactiveProperty<float>();
        public IReadOnlyReactiveProperty<float> SampleSingle => _sampleSingle;
        private SampleSO _so;

        public MainSceneModel(SampleSO so)
        {
            Debug.Log("MainSceneModel is constructed");

            _so = so;
            Debug.Log(_so.GetType());
            Debug.Log(_so.Name);
        }
    }
}
