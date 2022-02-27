using UnityEngine;
using Zenject;

namespace VLS
{
    public class MultipleInstaller : MonoInstaller<MultipleInstaller>
    {
        public override void InstallBindings()
        {
            Debug.Log("MultipleInstaller run");
        }
    }
}
