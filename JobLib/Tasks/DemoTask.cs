using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobLib.Tasks
{
    public class DemoTask: IHostedService, IDisposable
    {
        private Timer? _timer = null;

        Task IHostedService.StartAsync(CancellationToken cancellationToken)
        {
            _timer = new Timer(DoJob, null, TimeSpan.Zero, TimeSpan.FromSeconds(5));
            return Task.CompletedTask;
        }

        Task IHostedService.StopAsync(CancellationToken cancellationToken)
        {
            _timer?.Change(Timeout.Infinite, 0);
            return Task.CompletedTask;
        }

        private void DoJob(object? state)
        {
            var item = new { RequestID = "aaa3", Content = "aaa4" };
            Console.WriteLine($"ID: {item?.RequestID}, Content: {item?.Content}");
        }

        public void Dispose()
        {

        }
    }
}
