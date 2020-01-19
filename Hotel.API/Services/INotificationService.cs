using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.API.Services
{
	public interface INotificationService
	{
		void Notify(string message);
	}
}
