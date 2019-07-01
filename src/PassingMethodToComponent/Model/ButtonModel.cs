using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace PassingMethodToComponent.Model
{
    public class ButtonModel : ComponentBase
    {

        [Parameter]
        protected EventCallback ExternalMethod { get; set; }

        [Parameter]
        protected string Label { get; set; }
    }
}
