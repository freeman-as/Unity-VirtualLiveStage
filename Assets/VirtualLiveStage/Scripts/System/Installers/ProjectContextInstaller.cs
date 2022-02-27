using UnityEngine;
using Zenject;

namespace VLS
{
    public class ProjectContextInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Debug.Log("ProjectContextInstaller run");

            // System
            //Container.BindInterfacesAndSelfTo<EntryPoint>().AsTransient();
            //Container.Bind<MainSystem>().AsSingle();
        }
    }
}
