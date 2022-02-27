using UnityEngine;
using Zenject;

namespace VLS
{
    public class MainSceneInstaller : MonoInstaller<MainSceneInstaller>
    {
        [SerializeField]
        private MainSceneManager _mainSceneManager;

        public override void InstallBindings()
        {
            Debug.Log("MainSceneInstaller run");

            // System
            Container.BindInterfacesAndSelfTo<EntryPoint>().AsTransient();
            Container.Bind<MainSystem>().AsSingle();

            // Manager
            //Container.Bind<MainSceneManager>().AsSingle();
            Container.BindInstance(_mainSceneManager).AsSingle();

            // Service

            // Model

            // ViewModel

            // Presenter

            // View
        }

        private void InstallSubContainer(DiContainer subContainerr)
        {

        }
    }
}