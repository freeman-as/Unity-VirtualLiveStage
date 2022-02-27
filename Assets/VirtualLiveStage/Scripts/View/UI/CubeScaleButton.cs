using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using Zenject;
using UniRx;

namespace VLS.View
{
    public class CubeScaleButton : MonoBehaviour
    {
        [SerializeField]
        private CubeController _controller;

        [SerializeField]
        private Button _button;

        [Inject]
        public void Construct()
        {
            Debug.Log("CubeScaleButton is constructed");
        }

        /// <summary>
        /// �N���b�N�C�x���g�Ď��p
        /// </summary>
        /// <returns></returns>
        public IObservable<Unit> OnClicked()
        {
            return _button?.OnClickAsObservable();
        }

        private void Awake()
        {
            //_button = GetComponent<Button>();
        }

        /// <summary>
        /// �r���[��\��
        /// </summary>
        public void SetView(float scale)
        {
            Debug.Log("Click���ꂽ��");

            // CUbe���g��
            _controller?.ChangeScale(scale);
        }
    }
}

