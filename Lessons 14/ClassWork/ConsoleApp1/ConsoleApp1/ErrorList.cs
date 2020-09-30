using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	class ErrorList : IDisposable, IEnumerable<string>
	{

		public string Category		
		{
			get;
		}

		private List<string> _Errors
		{
			get; set;
		}

		public void Dispose()
		{
			_Errors.Clear();
			_Errors = null;
		}

		public ErrorList(string category)  // Конструктор
		{
			Category = category;
			_Errors = new List<string>();
		}

		public void Add(string errorMessage)
		{
			_Errors.Add(errorMessage);
		}

		public IEnumerator<string> GetEnumerator()
		{
			return ((IEnumerable<string>)_Errors).GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable)_Errors).GetEnumerator();
		}
	}
}
