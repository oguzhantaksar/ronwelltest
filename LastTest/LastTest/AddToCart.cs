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
    ///The AddToCart recording.
    /// </summary>
    [TestModule("2124a63d-0300-46d5-96fb-54f44e208b3d", ModuleType.Recording, 1)]
    public partial class AddToCart : ITestModule
    {
        /// <summary>
        /// Holds an instance of the LastTestRepository repository.
        /// </summary>
        public static LastTestRepository repo = LastTestRepository.Instance;

        static AddToCart instance = new AddToCart();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddToCart()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AddToCart Instance
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

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(0));
            Delay.Duration(1000, false);
            
            // Adds first product to cart
            Report.Log(ReportLevel.Info, "Mouse", "Adds first product to cart\r\nMouse Left Click item 'Trendyol.AddToCart' at 270;10.", repo.Trendyol.AddToCartInfo, new RecordItemIndex(1));
            repo.Trendyol.AddToCart.Click("270;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -480 units.", new RecordItemIndex(2));
            Mouse.ScrollWheel(-480);
            Delay.Milliseconds(300);
            
            // Goes to second products page
            Report.Log(ReportLevel.Info, "Mouse", "Goes to second products page\r\nMouse Left Click item 'Trendyol.Product2' at 98;155.", repo.Trendyol.Product2Info, new RecordItemIndex(3));
            repo.Trendyol.Product2.Click("98;155");
            Delay.Milliseconds(0);
            
            // Adds second product to cart
            Report.Log(ReportLevel.Info, "Mouse", "Adds second product to cart\r\nMouse Left Click item 'Trendyol.AddToCart' at 269;9.", repo.Trendyol.AddToCartInfo, new RecordItemIndex(4));
            repo.Trendyol.AddToCart.Click("269;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'Trendyol.AddedToCart'.", repo.Trendyol.AddedToCartInfo, new RecordItemIndex(5));
            Validate.Exists(repo.Trendyol.AddedToCartInfo);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
