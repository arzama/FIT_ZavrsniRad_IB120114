﻿

#pragma checksum "C:\Users\Arza\Desktop\Dipl_NoviTemp\V15-Novi temp -\PEPmodnaKompanija_Mobile\FavouriteAlbum\Pregled.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2C61CBDB47734CD9AB7A5A78943AF9F5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PEPmodnaKompanija_Mobile.FavouriteAlbum
{
    partial class Pregled : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 26 "..\..\FavouriteAlbum\Pregled.xaml"
                ((global::Windows.UI.Xaml.Controls.ListViewBase)(target)).ItemClick += this.favouriteList_ItemClick;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 58 "..\..\FavouriteAlbum\Pregled.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.obrisiButton_Click;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 17 "..\..\FavouriteAlbum\Pregled.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.Selector)(target)).SelectionChanged += this.cijenaList_SelectionChanged;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}

