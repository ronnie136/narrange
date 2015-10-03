﻿using NArrange.Core.CodeElements;
using NArrange.CSharp;
using NUnit.Framework;
using System.Collections.ObjectModel;
using System.IO;

namespace NArrange.Tests.CSharp
{
	/// <summary>
	/// Class to assert that all C# 6.0 features work in NArrange.
	/// </summary>
	[TestFixture]
	public class CSharp6FeatureTests
	{
		#region Methods

		/// <summary>
		/// Tests the auto property initializer.
		/// </summary>
		[Test]
		public void TestAutoPropertyInitializers()
		{
			CSharpTestFile testFile = CSharpTestUtilities.GetAutoPropertyInitializersFile();
			using (TextReader reader = testFile.GetReader())
			{
				CSharpParser parser = new CSharpParser();
				ReadOnlyCollection<ICodeElement> elements = parser.Parse(reader);
			}
		}

		#endregion Methods
	}
}