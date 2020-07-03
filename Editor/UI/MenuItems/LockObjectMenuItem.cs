﻿using System;
using Innoactive.Creator.Core.Behaviors;
using Innoactive.CreatorEditor.UI.StepInspector.Menu;

namespace Innoactive.CreatorEditor.UI.Behaviors
{
    /// <inheritdoc />
    [Obsolete("Locking scene objects is obsoleted, consider using property locking.")]
    public class LockObjectMenuItem : MenuItem<IBehavior>
    {
        /// <inheritdoc />
        public override string DisplayedName { get; } = "Lock Object";

        /// <inheritdoc />
        public override IBehavior GetNewItem()
        {
            return new LockObjectBehavior();
        }
    }
}
