﻿using Innoactive.Creator.Core.Behaviors;
using Innoactive.CreatorEditor.UI.StepInspector.Menu;

namespace Innoactive.CreatorEditor.UI.Behaviors
{
    /// <inheritdoc />
    public class UnlockObjectMenuItem : MenuItem<IBehavior>
    {
        /// <inheritdoc />
        public override string DisplayedName { get; } = "Unlock Object";

        /// <inheritdoc />
        public override IBehavior GetNewItem()
        {
            return new UnlockObjectBehavior();
        }
    }
}
