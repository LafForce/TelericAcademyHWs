using System;

namespace _08.Events
{
    public class Publisher
    {
        public delegate void CustomEventHandler(object sender, SampleEvent e);

        public event CustomEventHandler RaiseCustomEvent;

        public void RaiseSampleEvent()
        {
            OnRaiseCustomEvent(new SampleEvent("This is a new event"));
        }

        protected virtual void OnRaiseCustomEvent(SampleEvent e)
        {
            CustomEventHandler handler = RaiseCustomEvent;

            if (handler != null)
            {
                e.SampleMessage += String.Format(" at {0}", DateTime.Now);

                handler(this, e);
            }
        }
    }
}
