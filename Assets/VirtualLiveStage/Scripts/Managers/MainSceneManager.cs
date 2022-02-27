using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Zenject;
using Cysharp.Threading.Tasks;

namespace VLS
{
    public class MainSceneManager : MonoBehaviour
    {
        [SerializeField]
        private GameObject _stage;

        [SerializeField]
        private Transform _stageRoot;

        [Inject] DiContainer _container;

        private void Awake()
        {
        }

        async void Start()
        {
            await UniTask.Delay(3000);
            //Instantiate(_stage, _stageRoot);

            // �X�e�[�W������
            // ���I��������Inject
            _container.InstantiatePrefab(_stage, _stageRoot);

            Debug.Log("MainSceneManager Start");
        }

        void Update()
        {
        }
    }
}
