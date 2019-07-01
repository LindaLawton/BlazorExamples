using System;
using Microsoft.AspNetCore.Components;

namespace PassingMethodToComponent.Model
{
    public class ButtonModelTwo : ComponentBase
    {

        [Parameter]
        protected string Label { get; set; }

        [Parameter] public Action ParentMethod { get; set; }

        public void InvokeParentMethod()
        {
            ParentMethod?.Invoke();
        }
    }
}