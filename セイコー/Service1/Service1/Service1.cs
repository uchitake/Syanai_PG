using System;
using System.Diagnostics;
using System.ServiceProcess;
using System.Timers;

namespace Service1
{
    public partial class Service1 : ServiceBase
    {
        private int count;

        private Timer timer = new Timer();

        public Service1()
        {
            InitializeComponent();

        }

        protected override void OnStart(string[] args)
        {
            SetCount();
        }

        protected override void OnStop()
        {
            StopCount();
        }

        /// <summary>
        /// 一定処理
        /// <param name=""></param>
        /// </summary>
        private void SetCount()
        {

            this.timer.Interval = 1000;

            this.timer.Elapsed += new ElapsedEventHandler(OnTimerEvent);

            this.timer.Start();

        }

        /// <summary>
        /// 停止処理
        /// <param name=""></param>
        /// </summary>
        private void StopCount()
        {
            timer.Stop();
        }

        /// <summary>
        /// カウント処理
        /// <param name=""></param>
        /// </summary>
        private void OnTimerEvent(object source, ElapsedEventArgs e)
        {
            // TODO:
            Debug.WriteLine("Tick : " + DateTime.Now);

            string sourceName = "MySource";

            byte[] myData = new byte[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //ソースが存在していない時は、作成する
            if (!System.Diagnostics.EventLog.SourceExists(sourceName))
            {
                //ログ名を空白にすると、"Application"となる
                System.Diagnostics.EventLog.CreateEventSource(sourceName, "");
            }

            System.Diagnostics.EventLog.WriteEntry(
    sourceName, "Tick : " + DateTime.Now,
    System.Diagnostics.EventLogEntryType.Error, 1, 1000, myData);
        }
    }
}
