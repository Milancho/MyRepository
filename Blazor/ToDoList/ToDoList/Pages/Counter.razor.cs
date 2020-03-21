using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace ToDoList.Pages
{
    public partial class Counter
    {
        private int currentCount = 0;

        [Parameter]
        public int IncrementAmount { get; set; } = 1;

        private void IncrementCount()
        {
            Console.WriteLine("IncrementAmount!");
            currentCount += IncrementAmount;
        }

        void Handler(MouseEventArgs args)
        {
            Console.WriteLine("I am clicked!");
            currentCount += IncrementAmount;
            InvokeAsync(StateHasChanged);
        }

        void Like(MouseEventArgs args)
        {
            Console.WriteLine("I am clicked!");
            currentCount += IncrementAmount;
            InvokeAsync(StateHasChanged);
        }
    }
}
