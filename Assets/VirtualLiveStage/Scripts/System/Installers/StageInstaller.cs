using UnityEngine;
using Zenject;


using VLS.Presenter;
using VLS.Model;
using VLS.View;

namespace VLS
{
    public class StageInstaller : MonoInstaller<StageInstaller>
    {
        [SerializeField]
        private StageManager _stageManager;

        public override void InstallBindings()
        {
            Debug.Log("StageInstaller run");

            Container.BindInstance(_stageManager).AsSingle();

            // Model
            Container.Bind<StageModel>().AsSingle();

            // Presenter
            // –¾¦“I‚É‰Šú‰»‚·‚é
            Container.Bind<StagePresenter>().AsSingle().NonLazy();

            // View

        }
    }
}
