/*
 * Created by Ranorex
 * User: Administrator
 * Date: 26.10.2023
 * Time: 16:17
 *
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

using System.IO;
using System.Xml.Linq;
using System.Xml;

using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

namespace playground.utils
{
	/// <summary>
	/// Description of xml_json_ini_etc.
	/// </summary>
	[TestModule("0869D962-30A8-49C1-BFE3-683EB6B66953", ModuleType.UserCode, 1)]
	public class xml_json_ini_etc : ITestModule
	{
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public xml_json_ini_etc()
		{
			// Do not delete - a parameterless constructor is required!
		}

		/// <summary>
		/// Performs the playback of actions in this module.
		/// </summary>
		/// <remarks>You should not call this method directly, instead pass the module
		/// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
		/// that will in turn invoke this method.</remarks>
		void ITestModule.Run()
		{
			Mouse.DefaultMoveTime = 300;
			Keyboard.DefaultKeyPressTime = 100;
			Delay.SpeedFactor = 1.0;
		}
		
		public static void xml_to_json(){
			string org_directory = System.IO.Directory.GetCurrentDirectory();
			string source_xml = Path.Combine(org_directory, @"compare_xml\_source.xml");
			
			
			
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(source_xml);
			string json = JsonConvert.SerializeObject(doc);

			
		}
	}
}
