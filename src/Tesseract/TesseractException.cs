﻿
using System;
using System.Runtime.Serialization;

namespace Tesseract
{
	/// <summary>
	/// Desctiption of TesseractException.
	/// </summary>
	[Serializable]
	public class TesseractException : Exception
	{
		public TesseractException()
		{
		}

	 	public TesseractException(string message) : base(message)
		{
		}

		public TesseractException(string message, Exception innerException) : base(message, innerException)
		{
		}
	}
}
