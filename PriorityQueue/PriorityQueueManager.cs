using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServicesApp.PriorityQueue
{
    internal class PriorityQueueManager
    {
        private static PriorityQueue eventQueue = new PriorityQueue();

        public static PriorityQueue GetEventQueue()
        {
            return eventQueue;
        }

        // Method to add events to the queue
        public static void AddEvent(Event eventData, int priority)
        {
            eventQueue.Push(eventData, priority);
        }

        // Retrieve all events from the queue
        public static IEnumerable<Event> GetAllEvents()
        {
            List<Event> events = new List<Event>();
            PriorityQueue tempQueue = eventQueue;  // Create a temporary queue reference

            // Iterate through the queue and extract all events
            while (!PriorityQueue.IsEmpty(tempQueue))
            {
                Event nextEvent = PriorityQueue.Peek(tempQueue);  // Get the next event
                events.Add(nextEvent);  // Add event to the list
                tempQueue = PriorityQueue.Pop(tempQueue);  // Remove the highest-priority event
            }

            return events;
        }

        // Search for events based on a search term
        public static IEnumerable<Event> SearchEvents(string searchTerm)
        {
            var allEvents = GetAllEvents(); // Retrieve all events using the new method
            return allEvents.Where(ev => ev.EventName.ToLower().Contains(searchTerm));
        }

        internal static IEnumerable<Event> FilterEventsByCategory(string selectedCategory)
        {
            throw new NotImplementedException();
        }

        internal static IEnumerable<Event> FilterEventsByDate(DateTime selectedDate)
        {
            throw new NotImplementedException();
        }

        internal static IEnumerable<Event> GetRecommendedEvents(string searchTerm)
        {
            throw new NotImplementedException();
        }
    }
}

