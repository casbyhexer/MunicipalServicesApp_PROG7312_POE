using System;

namespace MunicipalServicesApp.PriorityQueue
{
    public class Event
    {
        public string EventName { get; set; }
        public DateTime Date { get; set; }
        public int Priority { get; set; }
        public string Category { get; internal set; }
    }

    internal class PriorityQueue
    {
        // Node class to represent each event in the priority queue
        public class Node
        {
            public Event Data;
            public int Priority;
            public Node Next;
        }

        /// <summary>
        /// Function to create a new node with event data
        /// </summary>
        public static Node NewNode(Event data, int priority)
        {
            Node temp = new Node
            {
                Data = data,
                Priority = priority,
                Next = null
            };
            return temp;
        }

        /// <summary>
        /// Returns the event at the head of the priority queue
        /// </summary>
        public static Event Peek(Node head)
        {
            return head.Data;
        }

        /// <summary>
        /// Removes the element with the highest priority from the list
        /// </summary>
        public static Node Pop(Node head)
        {
            head = head.Next;
            return head;
        }

        /// <summary>
        /// Function to push an event into the queue according to priority
        /// </summary>
        public static Node Push(Node head, Event data, int priority)
        {
            Node start = head;
            Node temp = NewNode(data, priority);

            // Special Case: The head of the list has lower priority than the new node
            if (head == null || head.Priority > priority)
            {
                temp.Next = head;
                head = temp;
            }
            else
            {
                // Traverse the list and find a position to insert the new node
                while (start.Next != null && start.Next.Priority <= priority)
                {
                    start = start.Next;
                }

                temp.Next = start.Next;
                start.Next = temp;
            }
            return head;
        }

        /// <summary>
        /// Checks if the queue is empty
        /// </summary>
        public static bool IsEmpty(Node head)
        {
            return head == null;
        }

        internal void Push(Event eventData, int priority)
        {
            throw new NotImplementedException();
        }

        internal static Node GetEventQueue()
        {
            throw new NotImplementedException();
        }

        internal static bool IsEmpty(PriorityQueue tempQueue)
        {
            throw new NotImplementedException();
        }

        internal static Event Peek(PriorityQueue tempQueue)
        {
            throw new NotImplementedException();
        }

        internal static PriorityQueue Pop(PriorityQueue tempQueue)
        {
            throw new NotImplementedException();
        }
    }

}
