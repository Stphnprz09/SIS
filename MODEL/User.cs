using System;
namespace MODEL
{
	public class User
	{
		public string fullName { get; set; }

        public User(string fullName)
        {
            this.fullName = fullName;
        }
    }
}

