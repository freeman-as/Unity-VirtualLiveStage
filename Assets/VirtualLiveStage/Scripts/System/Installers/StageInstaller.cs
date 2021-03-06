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
            // 明示的に初期化する
            Container.Bind<StagePresenter>().AsSingle().NonLazy();

            // View

        }
    }
}
