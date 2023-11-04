using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCancellationDemo
{
    class SortingService
    {
        readonly int dataSize;
        int[] data;

        public SortingService(int size)
        {
            dataSize = size;
            data = new int[dataSize];
            for (int i = 0; i < dataSize; i++)
            {
                data[i] = Random.Shared.Next(1_000_001);
            }
        }

        Thread worker;
        CancellationTokenSource cts;

        private void SortWorker(object p)
        {
            CancellationToken ct = (CancellationToken)p;
            for (int i = 0; i < dataSize; i++)
            {
                for (int j = i + 1; j < dataSize; j++)
                {
                    if (data[i] > data[j])
                    {
                        int tmp = data[i];
                        data[i] = data[j];
                        data[j] = tmp;
                    }
                }
                if (ct.IsCancellationRequested) { return; }
            }
            if (WorkCompleted is not null)
            {
                WorkCompleted();
            }
        }

        public void Start()
        {
            cts = new CancellationTokenSource();
            worker = new Thread(SortWorker);
            worker.Start(cts.Token);
        }

        public void Cancel()
        {
            if (worker == null) return;
            cts.Cancel();
            worker.Join();
            worker = null;
            if (WorkCancelled is not null)
            {
                WorkCancelled();
            }
        }

        public int First { get { return data[0]; } }

        public int Last { get { return data[dataSize - 1]; } }

        public Action WorkCompleted { get; set; }

        public Action WorkCancelled { get; set; }
    }
}
