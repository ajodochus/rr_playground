﻿/*
 * Created by Ranorex
 * User: Administrator
 * Date: 25.10.2023
 * Time: 17:16
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
using Org.XmlUnit.Builder;
using Org.XmlUnit.Diff;
using XmlDiffLib;

using System.Xml;
using System.Xml.Linq;

namespace playground.utils
{
    /// <summary>
    /// Description of test.
    /// </summary>
    [TestModule("8F70454C-3830-4EBD-8919-50DDAA899F48", ModuleType.UserCode, 1)]
    public class Table_handler : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Table_handler()
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
        
        public static void find_single_cell_value(Ranorex.Core.Repository.RepoItemInfo ItemInfo, string value_to_find){
        	Ranorex.Unknown tbl = ItemInfo.CreateAdapter<Ranorex.Unknown>(true);
       
        	Ranorex.Unknown cell_found = null;
        	
    		tbl.TryFindSingle("./Row/Cell[@Text='"+ value_to_find +"']", 5000, out cell_found);
       		string effected_column = cell_found.Element.GetAttributeValue("ChildIndex").ToString();// 1 or 2
       		string effected_row = cell_found.Element.GetAttributeValueText("AccessibleName").ToString();//Name Zeile 0, Nicht sortiert.
       		int result = Int32.Parse(Regex.Match(effected_row, @"\d+").Value) + 1;
        	Ranorex.Report.Info("effected col: " + effected_column);
        	Ranorex.Report.Info("effected row: " + result);
        }
        
        public static void read_tbl_into_dictionary(Ranorex.Core.Repository.RepoItemInfo ItemInfo){
        	
        	// read table content into dictionoary
        	Dictionary<string,string> dict_table = new Dictionary<string, string>();
        	string name = "";
        	string number = "";
        	
        	Ranorex.Unknown varTableIdentifier  = ItemInfo.CreateAdapter<Ranorex.Unknown>(true);			        
	        int rows = varTableIdentifier.Find("./Row").Count;
	        for (int i = 1; i <= rows; i++) {
	        	name = varTableIdentifier.FindSingle("./Row["+i+"]/Cell[2]").GetAttributeValueText("Text");
	        	number = varTableIdentifier.FindSingle("./Row["+i+"]/Cell[3]").GetAttributeValueText("Text");
	        	dict_table.Add(name,number);
	        }
	        
	        foreach(KeyValuePair<string,string> kv in dict_table){
	        	Ranorex.Report.Info(kv.Key +" - "+ kv.Value);
	        }
	        
		}
        
        public static void compare_xml_file_with_xml_code()
        {
             string org_directory = System.IO.Directory.GetCurrentDirectory();
             string source_xml = Path.Combine(org_directory, @"compare_xml\_source.xml");
             string compare_xml = Path.Combine(org_directory, @"compare_xml\_compare.xml");
             
             XmlDocument source_xml_parsed =  new XmlDocument();
             source_xml_parsed.Load(source_xml);
             
             XmlDocument compare_xml_parsed =  new XmlDocument();
             compare_xml_parsed.Load(compare_xml);
             
             var exclude_attributes = new List<string> { "", "", "some attributes to exclude from diff" };
             var exclude_nodes= new List<string> { "Component", "", "some nodes to exlude from diff" };
             
            var myDiff = DiffBuilder.Compare(Input.FromString(source_xml_parsed.InnerXml))
					.WithTest(Input.FromString(compare_xml_parsed.InnerXml))
					.WithNodeFilter(x => !exclude_nodes.Contains(x.Name))
					.WithAttributeFilter(x => !exclude_attributes.Contains(x.Name))
					.Build();
            
            var sb = new StringBuilder();
            foreach(var dif in myDiff.Differences){    	
            	sb.AppendLine(dif.Comparison.ToString());   	
            }
			if (myDiff.HasDifferences()) {
				Ranorex.Report.Info("xml differs: " + sb.ToString());
			}
				
        }
    }
}
