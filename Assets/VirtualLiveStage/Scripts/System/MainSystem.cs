using UnityEngine;

namespace VLS
{
    public class MainSystem
    {
        private readonly MainSceneManager _mainSceneManager;

        public MainSystem(MainSceneManager mainSceneManager)
        {
            Debug.Log("MainSystem is constructed");

            _mainSceneManager = mainSceneManager;
        }

        public void Initialize()
        {

        }
    }
}

