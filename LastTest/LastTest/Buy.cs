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
    ///The Buy recording.
    /// </summary>
    [TestModule("c67b90d9-3f46-4b72-912a-e9dce6055501", ModuleType.Recording, 1)]
    public partial class Buy : ITestModule
    {
        /// <summary>
        /// Holds an instance of the LastTestRepository repository.
        /// </summary>
        public static LastTestRepository repo = LastTestRepository.Instance;

        static Buy instance = new Buy();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Buy()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Buy Instance
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

            // Assuming that there are more than one items in the cart
            Report.Log(ReportLevel.Info, "Mouse", "Assuming that there are more than one items in the cart\r\nMouse Left Click item 'Trendyol.Buy' at 50;15.", repo.Trendyol.BuyInfo, new RecordItemIndex(0));
            repo.Trendyol.Buy.Click("50;15");
            Delay.Milliseconds(0);
            
            // After saving information such as adress, gsm, card information buying can be done.
            Report.Log(ReportLevel.Info, "Validation", "After saving information such as adress, gsm, card information buying can be done.\r\nValidating AttributeEqual (InnerText='Kaydet ve Devam Et') on item 'Trendyol.ContinueToBuy'.", repo.Trendyol.ContinueToBuyInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.Trendyol.ContinueToBuyInfo, "InnerText", "Kaydet ve Devam Et");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
