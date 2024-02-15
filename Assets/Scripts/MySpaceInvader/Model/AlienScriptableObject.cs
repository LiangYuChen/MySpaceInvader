using System;
using MySpaceInvader.Define;
using UnityEngine;

namespace MySpaceInvader.Model
{
    [CreateAssetMenu(fileName = "AlienData", menuName = "ScriptableObjects/Alien", order = 1)]
    public class AlienScriptableObject : ScriptableObject
    {
        [Serializable]
        public class AlienData
        {
            public int id;
            public AlienType type;
        }

        public AlienData[] alienData;
    }
}