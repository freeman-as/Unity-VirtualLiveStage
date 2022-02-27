using UnityEngine;
using Zenject;

using VLS.Presenter;
using VLS.Model;
using VLS.View;


namespace VLS
{
    public class AppSettingInstaller : MonoInstaller<AppSettingInstaller>
    {
        public override void InstallBindings()
        {
            Debug.Log("AppSettingInstaller run");

            // Presenter
            // �����I�ɃC���X�^���X����
            Container.Bind<MainScenePresenter>().AsSingle().NonLazy();

            // Model
            Container.Bind<MainSceneModel>().AsSingle();
        }
    }
}
