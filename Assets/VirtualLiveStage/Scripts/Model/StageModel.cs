using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UniRx;

using VLS.Presenter;

namespace VLS.Model
{
    public class StageModel
    {
        private readonly IReactiveProperty<float> _cubeScake = new ReactiveProperty<float>();
        public IReadOnlyReactiveProperty<float> CubeScale => _cubeScake;
        public StageModel()
        {
            Debug.Log("StageModel is constructed");
        }

        public void UpdateScale(float scale)
        {
            if (_cubeScake.Value == scale) return;
            _cubeScake.Value = scale;
        }
    }
}
