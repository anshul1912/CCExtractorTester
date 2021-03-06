﻿using System;

namespace CCExtractorTester
{
	/// <summary>
	/// A class holding all the info that should be passed from the tester to the report generator.
	/// </summary>
	public class CompareData
	{
		/// <summary>
		/// Gets or sets the correct file.
		/// </summary>
		/// <value>The correct file.</value>
		public string CorrectFile { get; set; }
		/// <summary>
		/// Gets or sets the produced file.
		/// </summary>
		/// <value>The produced file.</value>
		public string ProducedFile { get; set; }
		/// <summary>
		/// Gets or sets the sample file.
		/// </summary>
		/// <value>The sample file.</value>
		public string SampleFile { get; set; }
		/// <summary>
		/// Gets or sets the commands used.
		/// </summary>
		/// <value>The command.</value>
		public string Command { get; set; }
		/// <summary>
		/// Gets or sets the run time of the entry.
		/// </summary>
		/// <value>The run time.</value>
		public TimeSpan RunTime { get; set; }
	}
}