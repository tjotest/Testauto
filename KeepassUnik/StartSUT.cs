﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

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
using Ranorex.Core.Repository;

namespace KeepassUnik
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The StartSUT recording.
    /// </summary>
    [TestModule("08a1daa5-c0da-4a99-9221-e57a7bf44f1d", ModuleType.Recording, 1)]
    public partial class StartSUT : ITestModule
    {
        /// <summary>
        /// Holds an instance of the KeepassUnikRepository repository.
        /// </summary>
        public static KeepassUnikRepository repo = KeepassUnikRepository.Instance;

        static StartSUT instance = new StartSUT();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public StartSUT()
        {
            varExP = "C:\\Users\\tjo\\Documents\\Ranorex\\RanorexStudio Projects\\KeepassUnik\\KeepassUnik\\KeePass\\KeePass.exe";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static StartSUT Instance
        {
            get { return instance; }
        }

#region Variables

        string _varExP;

        /// <summary>
        /// Gets or sets the value of variable varExP.
        /// </summary>
        [TestVariable("a57af48d-2555-4132-a4c0-8a868da5a1e4")]
        public string varExP
        {
            get { return _varExP; }
            set { _varExP = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.1")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.1")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Application", "Run application with file name from variable $varExP with arguments '' in normal mode.", new RecordItemIndex(0));
            Host.Local.RunApplication(varExP, "", "C:\\Users\\tjo\\Documents\\Ranorex\\RanorexStudio Projects\\KeepassUnik\\KeepassUnik\\KeePass", false);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
