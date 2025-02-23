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
    ///The AddToWishlist recording.
    /// </summary>
    [TestModule("c2ab2cf8-2689-4c9c-aa1c-eb1b08f37eda", ModuleType.Recording, 1)]
    public partial class AddToWishlist : ITestModule
    {
        /// <summary>
        /// Holds an instance of the LastTestRepository repository.
        /// </summary>
        public static LastTestRepository repo = LastTestRepository.Instance;

        static AddToWishlist instance = new AddToWishlist();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddToWishlist()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AddToWishlist Instance
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

            // ButtonFavs are clicked for adding to wishlist
            Report.Log(ReportLevel.Info, "Mouse", "ButtonFavs are clicked for adding to wishlist\r\nMouse Left Click item 'Trendyol.ButtonFav1' at 39;31.", repo.Trendyol.ButtonFav1Info, new RecordItemIndex(0));
            repo.Trendyol.ButtonFav1.Click("39;31");
            Delay.Milliseconds(0);
            
            // Scrolling down for more products
            Report.Log(ReportLevel.Info, "Mouse", "Scrolling down for more products\r\nMouse Left Down item 'Trendyol' at 1910;144.", repo.Trendyol.SelfInfo, new RecordItemIndex(1));
            repo.Trendyol.Self.MoveTo("1910;144");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'Trendyol' at 1902;248.", repo.Trendyol.SelfInfo, new RecordItemIndex(2));
            repo.Trendyol.Self.MoveTo("1902;248");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Trendyol.Wishlist_buttons.ButtonFav3' at 33;20.", repo.Trendyol.Wishlist_buttons.ButtonFav3Info, new RecordItemIndex(3));
            repo.Trendyol.Wishlist_buttons.ButtonFav3.Click("33;20");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Trendyol.Wishlist_buttons.ButtonFav4' at 33;22.", repo.Trendyol.Wishlist_buttons.ButtonFav4Info, new RecordItemIndex(4));
            repo.Trendyol.Wishlist_buttons.ButtonFav4.Click("33;22");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Trendyol.Wishlist_buttons.ButtonFav2' at 29;21.", repo.Trendyol.Wishlist_buttons.ButtonFav2Info, new RecordItemIndex(5));
            repo.Trendyol.Wishlist_buttons.ButtonFav2.Click("29;21");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'Trendyol' at 1910;200.", repo.Trendyol.SelfInfo, new RecordItemIndex(6));
            repo.Trendyol.Self.MoveTo("1910;200");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            // Scrolling up  for clicking wishlist
            Report.Log(ReportLevel.Info, "Mouse", "Scrolling up  for clicking wishlist\r\nMouse Left Up item 'Trendyol' at 1919;62.", repo.Trendyol.SelfInfo, new RecordItemIndex(7));
            repo.Trendyol.Self.MoveTo("1919;62");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Trendyol.Wishlist' at 28;9.", repo.Trendyol.WishlistInfo, new RecordItemIndex(8));
            repo.Trendyol.Wishlist.Click("28;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'Trendyol.AddedToWishlist'.", repo.Trendyol.AddedToWishlistInfo, new RecordItemIndex(9));
            Validate.Exists(repo.Trendyol.AddedToWishlistInfo);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
