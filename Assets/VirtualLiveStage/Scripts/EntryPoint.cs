using UnityEngine;

using Zenject;

namespace VLS
{
    public class EntryPoint : IInitializable
    {
        private readonly MainSystem _mainSystem;

        public EntryPoint(MainSystem mainSystem)
        {
            Debug.Log("EntryPoint is constructed");
            _mainSystem = mainSystem;
        }
        void IInitializable.Initialize()
        {
            _mainSystem.Initialize();
        }
    }

}
