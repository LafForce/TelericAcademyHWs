namespace TaskOneCSharp
{
	using System;
	using System.Text;

	public static class Messages
	{
		private static StringBuilder thisOutput = new StringBuilder();

		public static StringBuilder Output
		{
			get { return thisOutput; }
		}

		public static void EventAdded()
		{
			thisOutput.Append("Event added\n");
		}

		public static void EventDeleted(int x)
		{
			if (x == 0)
			{
				NoEventsFound();
			}
			else
			{
				thisOutput.AppendFormat("{0} events deleted\n", x);
			}
		}

		public static void NoEventsFound()
		{
			thisOutput.Append("No events found\n");
		}

		public static void PrintEvent(Event eventToPrint)
		{
			if (eventToPrint != null)
			{
				thisOutput.Append(eventToPrint + "\n");
			}
		}

		internal static void PrintEvent(object eventToShow)
		{
			throw new NotImplementedException();
		}
	}
}
