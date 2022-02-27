using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UniRx;

using VLS.Model;
using VLS.View;

namespace VLS.Presenter
{
    public class MainScenePresenter
    {
        private readonly MainSceneModel _mainSceneModel;

        public MainScenePresenter(
            MainSceneModel mainSceneModel
            )
        {
            Debug.Log("MainScenePresenter is constructed");

            _mainSceneModel = mainSceneModel;
        }

    }
}
