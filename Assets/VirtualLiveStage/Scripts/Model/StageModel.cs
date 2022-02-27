using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UniRx;

namespace VLS.Model
{
    public class StageModel
    {
        private readonly IReactiveProperty<float> _cubeScale = new ReactiveProperty<float>();
        public IReadOnlyReactiveProperty<float> CubeScale => _cubeScale;
        public StageModel()
        {
            Debug.Log("StageModel is constructed");
        }

        public void UpdateScale(float scale)
        {
            if (_cubeScale.Value == scale) return;
            _cubeScale.Value = scale;
        }
    }
}
