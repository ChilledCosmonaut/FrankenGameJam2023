using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Events
{
    public class EventManager : MonoBehaviour
    {
        public List<Event> events = new();
        private List<Coroutine> _scheduledEvents = new();
        
        private void Start()
        {
            foreach (Event eventDef in events)
            {
                _scheduledEvents.Add(StartCoroutine(ScheduleEvent(eventDef)));
            }
        }

        private IEnumerator ScheduleEvent(Event eventDef)
        {
            float randomizedIdleTime = GetRandomizedTime(eventDef.timeTillSpawn);
            yield return new WaitForSeconds(randomizedIdleTime);


            ProcessEvent(eventDef);
        }
        
        private float GetRandomizedTime(Range<float> timeRange)
        {
            return UnityEngine.Random.Range(timeRange.min, timeRange.max);
        }

        private void ProcessEvent(Event eventDef)
        {
            var eventInstance = Instantiate(eventDef.eventMarker, eventDef.location, Quaternion.identity);
        }

        private void OnDestroy()
        {
            for(int i = 0; i <= _scheduledEvents.Count; i++)
            {
                StopCoroutine(_scheduledEvents[i]);
                _scheduledEvents.RemoveAt(i);
            }
        }
    }
}
