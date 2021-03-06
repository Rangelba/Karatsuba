﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 10.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestKara
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "10.0.40219.445")]
    public partial class UIMap
    {
        
        /// <summary>
        /// LoadKara - Use 'LoadKaraParams' to pass parameters into this method.
        /// </summary>
        public void LoadKara()
        {
            #region Variable Declarations
            WinComboBox uIOpenComboBox = this.UIRunWindow.UIItemWindow.UIOpenComboBox;
            WinButton uIOKButton = this.UIRunWindow.UIOKWindow.UIOKButton;
            WpfEdit uIMultiplicandoEdit = this.UIMainWindowWindow.UIMultiplicandoEdit;
            WinButton uIOKButton1 = this.UIOKWindow.UIOKButton;
            WpfEdit uIMultiplicadorEdit = this.UIMainWindowWindow.UIMultiplicadorEdit;
            WpfButton uICalcularButton = this.UIMainWindowWindow.UICalcularButton;
            #endregion

            // Press keyboard shortcut keys 'Windows + R'
            Keyboard.SendKeys(this.LoadKaraParams.SendKeys, ModifierKeys.Windows);

            // Select 'E:\\codetag\Karatsuba' in 'Open:' combo box
            uIOpenComboBox.EditableItem = this.LoadKaraParams.UIOpenComboBoxEditableItem;

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(15, 13));

            // Type '1234' in 'Multiplicando' text box
            uIMultiplicandoEdit.Text = this.LoadKaraParams.UIMultiplicandoEditText;

            // Type 'd' in 'Multiplicando' text box
            Keyboard.SendKeys(uIMultiplicandoEdit, this.LoadKaraParams.UIMultiplicandoEditSendKeys, ModifierKeys.None);

            // Click 'OK' button
            Mouse.Click(uIOKButton1, new Point(19, 6));

            // Click 'Multiplicando' text box
            Mouse.Click(uIMultiplicandoEdit, new Point(181, 11));

            // Type '{%}' in 'Multiplicando' text box
            Keyboard.SendKeys(uIMultiplicandoEdit, this.LoadKaraParams.UIMultiplicandoEditSendKeys1, ModifierKeys.None);

            // Click 'OK' button
            Mouse.Click(uIOKButton1, new Point(32, 7));

            // Move 'Multiplicando' text box from (188, 10) to (82, 10)
            Mouse.StartDragging(uIMultiplicandoEdit, new Point(188, 10));
            Mouse.StopDragging(uIMultiplicandoEdit, -106, 0);

            // Type '&' in 'Multiplicando' text box
            Keyboard.SendKeys(uIMultiplicandoEdit, this.LoadKaraParams.UIMultiplicandoEditSendKeys2, ModifierKeys.None);

            // Click 'OK' button
            Mouse.Click(uIOKButton1, new Point(28, 12));

            // Type '5678' in 'Multiplicador' text box
            uIMultiplicadorEdit.Text = this.LoadKaraParams.UIMultiplicadorEditText;

            // Type '{#}' in 'Multiplicador' text box
            Keyboard.SendKeys(uIMultiplicadorEdit, this.LoadKaraParams.UIMultiplicadorEditSendKeys, ModifierKeys.None);

            // Click 'OK' button
            Mouse.Click(uIOKButton1, new Point(52, 13));

            // Click 'Calcular' button
            Mouse.Click(uICalcularButton, new Point(69, 13));

            // Type '12344' in 'Multiplicando' text box
            uIMultiplicandoEdit.Text = this.LoadKaraParams.UIMultiplicandoEditText1;

            // Type '567' in 'Multiplicador' text box
            uIMultiplicadorEdit.Text = this.LoadKaraParams.UIMultiplicadorEditText1;

            // Click 'Calcular' button
            Mouse.Click(uICalcularButton, new Point(66, 9));

            // Type '123445678924445' in 'Multiplicando' text box
            uIMultiplicandoEdit.Text = this.LoadKaraParams.UIMultiplicandoEditText2;

            // Type '56742123423423' in 'Multiplicador' text box
            uIMultiplicadorEdit.Text = this.LoadKaraParams.UIMultiplicadorEditText2;

            // Click 'Calcular' button
            Mouse.Click(uICalcularButton, new Point(68, 15));
        }
        
        #region Properties
        public virtual LoadKaraParams LoadKaraParams
        {
            get
            {
                if ((this.mLoadKaraParams == null))
                {
                    this.mLoadKaraParams = new LoadKaraParams();
                }
                return this.mLoadKaraParams;
            }
        }
        
        public UIRunWindow UIRunWindow
        {
            get
            {
                if ((this.mUIRunWindow == null))
                {
                    this.mUIRunWindow = new UIRunWindow();
                }
                return this.mUIRunWindow;
            }
        }
        
        public UIDebugWindow UIDebugWindow
        {
            get
            {
                if ((this.mUIDebugWindow == null))
                {
                    this.mUIDebugWindow = new UIDebugWindow();
                }
                return this.mUIDebugWindow;
            }
        }
        
        public UIMainWindowWindow UIMainWindowWindow
        {
            get
            {
                if ((this.mUIMainWindowWindow == null))
                {
                    this.mUIMainWindowWindow = new UIMainWindowWindow();
                }
                return this.mUIMainWindowWindow;
            }
        }
        
        public UIOKWindow1 UIOKWindow
        {
            get
            {
                if ((this.mUIOKWindow == null))
                {
                    this.mUIOKWindow = new UIOKWindow1();
                }
                return this.mUIOKWindow;
            }
        }
        
        public UIMainWindowWindow1 UIMainWindowWindow1
        {
            get
            {
                if ((this.mUIMainWindowWindow1 == null))
                {
                    this.mUIMainWindowWindow1 = new UIMainWindowWindow1();
                }
                return this.mUIMainWindowWindow1;
            }
        }
        #endregion
        
        #region Fields
        private LoadKaraParams mLoadKaraParams;
        
        private UIRunWindow mUIRunWindow;
        
        private UIDebugWindow mUIDebugWindow;
        
        private UIMainWindowWindow mUIMainWindowWindow;
        
        private UIOKWindow1 mUIOKWindow;
        
        private UIMainWindowWindow1 mUIMainWindowWindow1;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'LoadKara'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.40219.445")]
    public class LoadKaraParams
    {
        
        #region Fields
        /// <summary>
        /// Press keyboard shortcut keys 'Windows + R'
        /// </summary>
        public string SendKeys = "R";
        
        /// <summary>
        /// Select 'E:\\codetag\Karatsuba' in 'Open:' combo box
        /// </summary>
        public string UIOpenComboBoxEditableItem = "E:\\\\codetag\\Karatsuba";
        
        /// <summary>
        /// Type '1234' in 'Multiplicando' text box
        /// </summary>
        public string UIMultiplicandoEditText = "1234";
        
        /// <summary>
        /// Type 'd' in 'Multiplicando' text box
        /// </summary>
        public string UIMultiplicandoEditSendKeys = "d";
        
        /// <summary>
        /// Type '{%}' in 'Multiplicando' text box
        /// </summary>
        public string UIMultiplicandoEditSendKeys1 = "{%}";
        
        /// <summary>
        /// Type '&' in 'Multiplicando' text box
        /// </summary>
        public string UIMultiplicandoEditSendKeys2 = "&";
        
        /// <summary>
        /// Type '5678' in 'Multiplicador' text box
        /// </summary>
        public string UIMultiplicadorEditText = "5678";
        
        /// <summary>
        /// Type '{#}' in 'Multiplicador' text box
        /// </summary>
        public string UIMultiplicadorEditSendKeys = "{#}";
        
        /// <summary>
        /// Type '12344' in 'Multiplicando' text box
        /// </summary>
        public string UIMultiplicandoEditText1 = "12344";
        
        /// <summary>
        /// Type '567' in 'Multiplicador' text box
        /// </summary>
        public string UIMultiplicadorEditText1 = "567";
        
        /// <summary>
        /// Type '123445678924445' in 'Multiplicando' text box
        /// </summary>
        public string UIMultiplicandoEditText2 = "123445678924445";
        
        /// <summary>
        /// Type '56742123423423' in 'Multiplicador' text box
        /// </summary>
        public string UIMultiplicadorEditText2 = "56742123423423";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.40219.445")]
    public class UIRunWindow : WinWindow
    {
        
        public UIRunWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Run";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "#32770";
            this.WindowTitles.Add("Run");
            #endregion
        }
        
        #region Properties
        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this);
                }
                return this.mUIItemWindow;
            }
        }
        
        public UIItemWindow1 UIItemWindow1
        {
            get
            {
                if ((this.mUIItemWindow1 == null))
                {
                    this.mUIItemWindow1 = new UIItemWindow1(this);
                }
                return this.mUIItemWindow1;
            }
        }
        
        public UIOKWindow UIOKWindow
        {
            get
            {
                if ((this.mUIOKWindow == null))
                {
                    this.mUIOKWindow = new UIOKWindow(this);
                }
                return this.mUIOKWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIItemWindow mUIItemWindow;
        
        private UIItemWindow1 mUIItemWindow1;
        
        private UIOKWindow mUIOKWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.40219.445")]
    public class UIItemWindow : WinWindow
    {
        
        public UIItemWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "12298";
            this.WindowTitles.Add("Run");
            #endregion
        }
        
        #region Properties
        public WinComboBox UIOpenComboBox
        {
            get
            {
                if ((this.mUIOpenComboBox == null))
                {
                    this.mUIOpenComboBox = new WinComboBox(this);
                    #region Search Criteria
                    this.mUIOpenComboBox.SearchProperties[WinComboBox.PropertyNames.Name] = "Open:";
                    this.mUIOpenComboBox.WindowTitles.Add("Run");
                    #endregion
                }
                return this.mUIOpenComboBox;
            }
        }
        #endregion
        
        #region Fields
        private WinComboBox mUIOpenComboBox;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.40219.445")]
    public class UIItemWindow1 : WinWindow
    {
        
        public UIItemWindow1(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "1001";
            this.WindowTitles.Add("Run");
            #endregion
        }
        
        #region Properties
        public WinEdit UIOpenEdit
        {
            get
            {
                if ((this.mUIOpenEdit == null))
                {
                    this.mUIOpenEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUIOpenEdit.SearchProperties[WinEdit.PropertyNames.Name] = "Open:";
                    this.mUIOpenEdit.WindowTitles.Add("Run");
                    #endregion
                }
                return this.mUIOpenEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUIOpenEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.40219.445")]
    public class UIOKWindow : WinWindow
    {
        
        public UIOKWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "1";
            this.WindowTitles.Add("Run");
            #endregion
        }
        
        #region Properties
        public WinButton UIOKButton
        {
            get
            {
                if ((this.mUIOKButton == null))
                {
                    this.mUIOKButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIOKButton.SearchProperties[WinButton.PropertyNames.Name] = "OK";
                    this.mUIOKButton.WindowTitles.Add("Run");
                    #endregion
                }
                return this.mUIOKButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIOKButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.40219.445")]
    public class UIDebugWindow : WinWindow
    {
        
        public UIDebugWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Debug";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "CabinetWClass";
            this.WindowTitles.Add("Debug");
            #endregion
        }
        
        #region Properties
        public UIItemWindow2 UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow2(this);
                }
                return this.mUIItemWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIItemWindow2 mUIItemWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.40219.445")]
    public class UIItemWindow2 : WinWindow
    {
        
        public UIItemWindow2(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.AccessibleName] = "Items View";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "DirectUIHWND";
            this.WindowTitles.Add("Debug");
            #endregion
        }
        
        #region Properties
        public UIKaratsubaListItem UIKaratsubaListItem
        {
            get
            {
                if ((this.mUIKaratsubaListItem == null))
                {
                    this.mUIKaratsubaListItem = new UIKaratsubaListItem(this);
                }
                return this.mUIKaratsubaListItem;
            }
        }
        #endregion
        
        #region Fields
        private UIKaratsubaListItem mUIKaratsubaListItem;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.40219.445")]
    public class UIKaratsubaListItem : WinListItem
    {
        
        public UIKaratsubaListItem(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinListItem.PropertyNames.Name] = "Karatsuba";
            this.WindowTitles.Add("Debug");
            #endregion
        }
        
        #region Properties
        public WinEdit UINameEdit
        {
            get
            {
                if ((this.mUINameEdit == null))
                {
                    this.mUINameEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUINameEdit.SearchProperties[WinEdit.PropertyNames.Name] = "Name";
                    this.mUINameEdit.WindowTitles.Add("Debug");
                    #endregion
                }
                return this.mUINameEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUINameEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.40219.445")]
    public class UIMainWindowWindow : WpfWindow
    {
        
        public UIMainWindowWindow()
        {
            #region Search Criteria
            this.SearchProperties[WpfWindow.PropertyNames.Name] = "MainWindow";
            this.SearchProperties.Add(new PropertyExpression(WpfWindow.PropertyNames.ClassName, "HwndWrapper", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("MainWindow");
            #endregion
        }
        
        #region Properties
        public WpfEdit UIMultiplicandoEdit
        {
            get
            {
                if ((this.mUIMultiplicandoEdit == null))
                {
                    this.mUIMultiplicandoEdit = new WpfEdit(this);
                    #region Search Criteria
                    this.mUIMultiplicandoEdit.SearchProperties[WpfEdit.PropertyNames.AutomationId] = "Multiplicando";
                    this.mUIMultiplicandoEdit.WindowTitles.Add("MainWindow");
                    #endregion
                }
                return this.mUIMultiplicandoEdit;
            }
        }
        
        public WpfEdit UIMultiplicadorEdit
        {
            get
            {
                if ((this.mUIMultiplicadorEdit == null))
                {
                    this.mUIMultiplicadorEdit = new WpfEdit(this);
                    #region Search Criteria
                    this.mUIMultiplicadorEdit.SearchProperties[WpfEdit.PropertyNames.AutomationId] = "Multiplicador";
                    this.mUIMultiplicadorEdit.WindowTitles.Add("MainWindow");
                    #endregion
                }
                return this.mUIMultiplicadorEdit;
            }
        }
        
        public WpfButton UICalcularButton
        {
            get
            {
                if ((this.mUICalcularButton == null))
                {
                    this.mUICalcularButton = new WpfButton(this);
                    #region Search Criteria
                    this.mUICalcularButton.SearchProperties[WpfButton.PropertyNames.Name] = "Calcular";
                    this.mUICalcularButton.WindowTitles.Add("MainWindow");
                    #endregion
                }
                return this.mUICalcularButton;
            }
        }
        #endregion
        
        #region Fields
        private WpfEdit mUIMultiplicandoEdit;
        
        private WpfEdit mUIMultiplicadorEdit;
        
        private WpfButton mUICalcularButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.40219.445")]
    public class UIOKWindow1 : WinWindow
    {
        
        public UIOKWindow1()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "OK";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "Button";
            this.WindowTitles.Add("OK");
            #endregion
        }
        
        #region Properties
        public WinButton UIOKButton
        {
            get
            {
                if ((this.mUIOKButton == null))
                {
                    this.mUIOKButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIOKButton.SearchProperties[WinButton.PropertyNames.Name] = "OK";
                    this.mUIOKButton.WindowTitles.Add("OK");
                    #endregion
                }
                return this.mUIOKButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIOKButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.40219.445")]
    public class UIMainWindowWindow1 : WinWindow
    {
        
        public UIMainWindowWindow1()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "MainWindow";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "HwndWrapper", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("MainWindow");
            #endregion
        }
    }
}
