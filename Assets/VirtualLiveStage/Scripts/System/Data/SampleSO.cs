using System;
using UnityEngine;

namespace VLS
{
    [Serializable]
    [CreateAssetMenu(menuName = "VLS/Create SampleSO", fileName = "SampleSO")]
    public class SampleSO : ScriptableObject
    {
        [SerializeField] private string _Name;

        public string Name => _Name;
    }
}