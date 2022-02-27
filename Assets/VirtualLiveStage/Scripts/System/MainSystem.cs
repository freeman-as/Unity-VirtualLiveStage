using UnityEngine;

using Zenject;

namespace VLS
{
    public class MainSystem
    {
        private readonly MainSceneManager _mainSceneManager;
        private readonly DiContainer _container;

        public MainSystem(MainSceneManager mainSceneManager, DiContainer container)
        {
            Debug.Log("MainSystem is constructed");

            _mainSceneManager = mainSceneManager;
            _container = container;
        }

        public void Initialize()
        {
        }
    }
}

