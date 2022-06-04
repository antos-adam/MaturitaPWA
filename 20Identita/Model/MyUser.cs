using System;
using Microsoft.AspNetCore.Identity;

namespace _20Identita.Model
{
	public class MyUser : IdentityUser
	{
		public string? Jmeno { get; set; }
		public string? Prijmeni { get; set; }
	}
}

