﻿using asd;
using Nac.Altseed.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nac.Altseed.Test
{
	class Program
	{
		static void Main(string[] args)
		{
			AltseedTest test = new ReactiveTests.EasingTest();
			test.Run();
		}
	}
}