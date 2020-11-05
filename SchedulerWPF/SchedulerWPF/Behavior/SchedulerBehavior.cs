using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Xaml.Behaviors;
using Syncfusion.UI.Xaml.Scheduler;

namespace WpfScheduler
{
    public class SchedulerBehavior : Behavior<SfScheduler>
    {

        SfScheduler scheduler;

        protected override void OnAttached()
        {
            base.OnAttached();
            scheduler = this.AssociatedObject;
            this.AssociatedObject.ViewHeaderCellTapped += Scheduler_ViewHeaderCellTapped;
        }

        private void Scheduler_ViewHeaderCellTapped(object sender, ViewHeaderCellTappedEventArgs e)
        {
            var dateTime = e.DateTime.ToString();
            MessageBox.Show("Date"+" "+ dateTime,"HeaderCellTapped", MessageBoxButton.OK);
        }

        protected override void OnDetaching()
        {
            base.OnDetaching();
            this.AssociatedObject.ViewHeaderCellTapped -= Scheduler_ViewHeaderCellTapped;
            this.scheduler = null;
        }
    }
}
