﻿using GufENuffLogInApi.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GufENuffLogInApi.ViewModels
{
	public class LogInViewModel
	{
		[Required]
		public String Email { get; set; }
		[Required]
		[Password]
		public String Password { get; set; }
	}
}