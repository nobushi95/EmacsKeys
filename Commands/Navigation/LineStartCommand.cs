﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.ComponentModel.Design;
using Microsoft.VisualStudio.Text.Formatting;
using System.ComponentModel.Composition;

namespace Microsoft.VisualStudio.Editor.EmacsEmulation.Commands
{
    /// <summary>
    /// This command goes to the beginning of the line with Word Wrap on.
    /// 
    /// Keys: Ctrl-A | Home 
    /// </summary>
    [EmacsCommand(EmacsCommandID.LineStart)]
    internal class LineStartCommand : EmacsCommand
    {
        internal override void Execute(EmacsCommandContext context)
        {
            if (context.Manager.AfterSearch)
            {
                context.EditorOperations.MoveCaretToHome(false);
            }
            else
            {
                context.EditorOperations.MoveCaretToHome();
            }
        }
    }
}
