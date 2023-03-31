﻿#pragma checksum "C:\cp-21pap\SimplePaintApp\SimplePaintApp\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B9D1621691F6C1BFF48FD0F3BAAA63CF48BF9D4FAA396ABB5B943DCA7C6DB6EA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SimplePaintApp
{
    partial class MainWindow : 
        global::Microsoft.UI.Xaml.Window, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {

        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainWindow.xaml line 64
                {
                    this.DrawingCanvas = global::WinRT.CastExtensions.As<global::Microsoft.Graphics.Canvas.UI.Xaml.CanvasControl>(target);
                    ((global::Microsoft.Graphics.Canvas.UI.Xaml.CanvasControl)this.DrawingCanvas).Draw += this.DrawingCanvas_Draw;
                    ((global::Microsoft.Graphics.Canvas.UI.Xaml.CanvasControl)this.DrawingCanvas).PointerPressed += this.DrawingCanvas_PointerPressed;
                    ((global::Microsoft.Graphics.Canvas.UI.Xaml.CanvasControl)this.DrawingCanvas).PointerMoved += this.DrawingCanvas_PointerMoved;
                    ((global::Microsoft.Graphics.Canvas.UI.Xaml.CanvasControl)this.DrawingCanvas).PointerReleased += this.DrawingCanvas_PointerReleased;
                }
                break;
            case 3: // MainWindow.xaml line 21
                {
                    this.Line = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarToggleButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.AppBarToggleButton)this.Line).Click += this.LineButton_Click;
                }
                break;
            case 4: // MainWindow.xaml line 27
                {
                    this.Rectangle = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarToggleButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.AppBarToggleButton)this.Rectangle).Click += this.RectangleButton_Click;
                }
                break;
            case 5: // MainWindow.xaml line 32
                {
                    this.ColorsButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                }
                break;
            case 6: // MainWindow.xaml line 33
                {
                    this.LineColorBorder = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Border>(target);
                }
                break;
            case 7: // MainWindow.xaml line 34
                {
                    this.FillColorIcon = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.FontIcon>(target);
                }
                break;
            case 8: // MainWindow.xaml line 40
                {
                    this.ColorsPicker = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ColorPicker>(target);
                }
                break;
            case 9: // MainWindow.xaml line 50
                {
                    global::Microsoft.UI.Xaml.Controls.Button element9 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)element9).Click += this.SetLineColor_Click;
                }
                break;
            case 10: // MainWindow.xaml line 52
                {
                    global::Microsoft.UI.Xaml.Controls.Button element10 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)element10).Click += this.SetFillColor_Click;
                }
                break;
            case 11: // MainWindow.xaml line 54
                {
                    global::Microsoft.UI.Xaml.Controls.Button element11 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)element11).Click += this.CancelColors_Click;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Microsoft.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
