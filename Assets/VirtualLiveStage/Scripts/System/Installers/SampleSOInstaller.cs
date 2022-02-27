using UnityEngine;
using Zenject;


namespace VLS {
    [CreateAssetMenu(fileName = "SampleSOInstaller", menuName = "Installers/SampleSOInstaller")]
    public class SampleSOInstaller : ScriptableObjectInstaller<SampleSOInstaller>
    {
        [SerializeField]
        private SampleSO _sampleSO;

        public override void InstallBindings()
        {
            Debug.Log("SampleSOInstaller run");

            Container.BindInstance(_sampleSO).AsCached();
        }
    }
}