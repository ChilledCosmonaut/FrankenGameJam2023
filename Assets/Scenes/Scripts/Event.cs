using System;
using UnityEngine;

namespace Events
{
    [Serializable]
    public struct Range<T>
    {
        public T min; 
        public T max;
    }

    [Serializable]
    public struct Effect
    {
        public int money;
        public int reputation;
    }

    [CreateAssetMenu(fileName = "Event", menuName = "ScriptableObjects/Event", order = 1)]
    public class Event : ScriptableObject
    {
        public Range<float> RecurringTime = new Range<float>{ min = 0.5f , max = 1.0f };
        public string header;
        [TextArea]
        public string body;
        public Effect effect;
    }
}