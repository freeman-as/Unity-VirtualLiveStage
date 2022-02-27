using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UniRx;

using VLS.Model;
using VLS.View;

namespace VLS.Presenter
{
    public class StagePresenter
    {
        private readonly StageModel _stageModel;
        private readonly CubeScaleButton _cubeScaleButton;

        public StagePresenter(
            CubeScaleButton cubeScaleButton,
            StageModel stageModel
            )
        {
            Debug.Log("StagePresenter is constructed");

            _stageModel = stageModel;
            _cubeScaleButton = cubeScaleButton;

            SetSubscribe();
        }

        private void SetSubscribe()
        {
            _stageModel
                .CubeScale
                .Where(v => v != 0)
                .Subscribe(v =>
                {
                    Debug.Log("View SetView");

                    _cubeScaleButton.SetView(v);
                });


            _cubeScaleButton.OnClicked().Subscribe(_ =>
            {
                Debug.Log("Model UpdateScale");

                var scale = 5f;
                _stageModel.UpdateScale(scale);
            });
        }
    }
}
