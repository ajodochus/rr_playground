/*
 * Created by Ranorex
 * User: Administrator
 * Date: 26.10.2023
 * Time: 16:47
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

namespace playground.xml_json_ini_stuff
{
    /// <summary>
    /// Description of convert_xml_to_json.
    /// </summary>
    [TestModule("12B87BEA-DAEE-4AF6-8359-5D54677749D2", ModuleType.UserCode, 1)]
    public class convert_xml_to_json : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public convert_xml_to_json()
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
        	utils.xml_json_ini_etc.xml_to_json();
        }
    }
}
