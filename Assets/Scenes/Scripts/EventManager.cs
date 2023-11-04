using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Events
{
    public class EventManager : MonoBehaviour
    {
        public List<Event> events = new();
        private List<IEnumerator> _scheduledEvents = new();
        //public List<RandomizedEvent> randomizedEvents = new();
        //
        //private readonly Dictionary<RepeatingEvent, double> timerTracker = new();
        //private bool updateEvents;
        
        private void Start()
        {
            foreach (Event eventDef in events)
            {
                _scheduledEvents.Add(ScheduleEvent(eventDef));
                StartCoroutine(_scheduledEvents[-1]);
            }
        }

        private IEnumerator ScheduleEvent(Event eventDef)
        {
            float idleTime = eventDef.RecurringTime.min;
            yield return new WaitForSeconds(idleTime);
            ProcessEvent();
        }

        /*
        private float GetRandomizedTime((float min, float max) )
        {
                return 0.0f;
        }
        */

        private void ProcessEvent()
        {
            throw new NotImplementedException();
        }

        //
        //public void StartEvents()
        //{
        //    if (updateEvents)
        //        return;
        //
        //    repeatingEvents.ForEach(repeatingEvent => timerTracker.TryAdd(repeatingEvent, repeatingEvent.Timer));
        //    updateEvents = true;
        //}
        //
        //public void Update()
        //{
        //    if (updateEvents && Time.deltaTime > 0f)
        //    {
        //        foreach (var randomizedEvent in randomizedEvents)
        //        {
        //            Random rnd = new();
        //            if (Time.deltaTime == 0)
        //                break;
        //            if (0 == rnd.Next((int)(randomizedEvent.Probability / Time.deltaTime)))
        //            {
        //                randomizedEvent.ActivateEvent();
        //                break;
        //            }
        //        }
        //
        //        foreach (var repeatingEvent in repeatingEvents)
        //        {
        //            timerTracker[repeatingEvent] -= Time.deltaTime;
        //            if (timerTracker[repeatingEvent] <= 0)
        //            {
        //                repeatingEvent.ActivateEvent();
        //                timerTracker[repeatingEvent] = repeatingEvent.Timer;
        //            }
        //        }
        //    }
        //}
        //
        //public void StopEvents()
        //{
        //    updateEvents = false;
        //}
    }
}
