// Decompiled with JetBrains decompiler
// Type: WindowsFormsApplication1.Properties.Resources
// Assembly: WindowsFormsApplication1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 73D1CE30-46F1-425E-827D-66B3E6F8877A
// Assembly location: E:\Артём\Мои программы\Зачёркиватель.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace WindowsFormsApplication1.Properties
{
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
  [DebuggerNonUserCode]
  [CompilerGenerated]
  internal class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    internal Resources()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (WindowsFormsApplication1.Properties.Resources.resourceMan == null)
          WindowsFormsApplication1.Properties.Resources.resourceMan = new ResourceManager("WindowsFormsApplication1.Properties.Resources", typeof (WindowsFormsApplication1.Properties.Resources).Assembly);
        return WindowsFormsApplication1.Properties.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get => WindowsFormsApplication1.Properties.Resources.resourceCulture;
      set => WindowsFormsApplication1.Properties.Resources.resourceCulture = value;
    }

    internal static Bitmap format_text_strikethrough => (Bitmap) WindowsFormsApplication1.Properties.Resources.ResourceManager.GetObject("format-text-strikethrough", WindowsFormsApplication1.Properties.Resources.resourceCulture);
  }
}
