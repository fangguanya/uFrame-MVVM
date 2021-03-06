namespace Invert.uFrame.MVVM {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    
    
    public class CommandPage : CommandPageBase {
        public override Type ParentPage
        {
            get { return typeof (ElementPage); }
        }

        public override decimal Order
        {
            get { return 2; }
        }

        public override bool ShowInNavigation
        {
            get { return false; }
        }

        public override void GetContent(Invert.Core.GraphDesigner.IDocumentationBuilder _) {
            base.GetContent(_);
        }
    }
}
