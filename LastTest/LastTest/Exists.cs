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

namespace LastTest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Exists recording.
    /// </summary>
    [TestModule("400acab3-1036-4986-9d4e-77d37f218154", ModuleType.Recording, 1)]
    public partial class Exists : ITestModule
    {
        /// <summary>
        /// Holds an instance of the LastTestRepository repository.
        /// </summary>
        public static LastTestRepository repo = LastTestRepository.Instance;

        static Exists instance = new Exists();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Exists()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Exists Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            // Assuming that all fields are expected as container.
            Report.Log(ReportLevel.Info, "Validation", "Assuming that all fields are expected as container.\r\nValidating Exists on item 'Trendyol.AllFieldsInRegistrationPage'.", repo.Trendyol.AllFieldsInRegistrationPageInfo, new RecordItemIndex(0));
            Validate.Exists(repo.Trendyol.AllFieldsInRegistrationPageInfo);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
