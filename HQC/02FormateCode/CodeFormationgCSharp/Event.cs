namespace TaskOneCSharp
{
	using System;
	using System.Text;

	public class Event : IComparable
	{
		private DateTime thisDate;
		private string thisTitle;
		private string thisLocation;

		public Event(DateTime thisDate, string title, string location)
		{
			this.ThisDate = thisDate;
			this.Title = title;
			this.Location = location;
		}

		public DateTime ThisDate
		{
			get
			{
				return this.thisDate;
			}

			set
			{
				this.thisDate = value;
			}
		}

		public string Title
		{
			get
			{
				return this.thisTitle;
			}

			set
			{
				this.thisTitle = value;
			}
		}

		public string Location
		{
			get
			{
				return this.thisLocation;
			}

			set
			{
				this.thisLocation = value;
			}
		}

		public int CompareTo(object obj)
		{
			Event other = obj as Event;
			int byDate = this.ThisDate.CompareTo(other.ThisDate);
			int byTitle = this.Title.CompareTo(other.Title);

			int byLocation = this.Location.CompareTo(other.Location);
			if (byDate == 0)
			{
				if (byTitle == 0)
				{
					return byLocation;
				}
				else
				{
					return byTitle;
				}
			}
			else
			{
				return byDate;
			}
		}

		public override string ToString()
		{
			StringBuilder toString = new StringBuilder();
			toString.Append(this.ThisDate.ToString("yyyy-MM-ddTHH:mm:ss"));
			toString.Append(" | " + this.Title);
			if (this.Location != null && this.Location != string.Empty)
			{
				toString.Append(" | " + this.Location);
			}

			return toString.ToString();
		}
	}
}
