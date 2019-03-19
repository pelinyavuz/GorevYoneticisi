
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace IsletimSistemi_GorevYoneticisi_
{
    public abstract class CpuUsageMonitorBase : Form1
    {
        object locker = new object();

        Timer timer;

        protected PerformanceCounter cpuPerformanceCounter = null;


        int valueArrayCapacity;


        List<double> cpuUsageValueArray;

        public event EventHandler<CpuUsageValueArrayChangedEventArg> CpuUsageValueArrayChanged;


        public event EventHandler<ErrorEventArgs> ErrorOccurred;

        public CpuUsageMonitorBase(int timerPeriod, int valueArrayCapacity,
            string categoryName, string counterName, string instanceName)
        {


            this.cpuPerformanceCounter =
                new PerformanceCounter(categoryName, counterName, instanceName);

            this.valueArrayCapacity = valueArrayCapacity;
            cpuUsageValueArray = new List<double>();

            if (timerPeriod > 0)
            {


                this.timer = new Timer(new TimerCallback(Timer_Callback),
                    null, timerPeriod, timerPeriod);
            }
        }

        void Timer_Callback(object obj)
        {
            lock (locker)
            {

                if (this.cpuUsageValueArray.Count > this.valueArrayCapacity)
                {
                    this.cpuUsageValueArray.Clear();
                }

                try
                {
                    double value = GetCpuUsage();

                    if (value < 0)
                    {
                        value = 0;
                    }
                    if (value > 100)
                    {
                        value = 100;
                    }

                    this.cpuUsageValueArray.Add(value);

                    double[] values = new double[cpuUsageValueArray.Count];
                    cpuUsageValueArray.CopyTo(values, 0);

                    this.OnCpuUsageValueArrayChanged(
                        new CpuUsageValueArrayChangedEventArg() { Values = values });
                }
                catch (Exception ex)
                {
                    this.OnErrorOccurred(new ErrorEventArgs { Error = ex });
                }
            }
        }

        protected virtual double GetCpuUsage()
        {
            if (!IsInstanceExist())
            {
                throw new ApplicationException(
                    string.Format("The instance {0} is not available. ",
                    this.cpuPerformanceCounter.InstanceName));
            }


            double value = cpuPerformanceCounter.NextValue();
            return value;
        }

        protected virtual bool IsInstanceExist()
        {
            return true;
        }


        protected virtual void OnCpuUsageValueArrayChanged(CpuUsageValueArrayChangedEventArg e)
        {
            if (this.CpuUsageValueArrayChanged != null)
            {
                this.CpuUsageValueArrayChanged(this, e);
            }
        }

        protected virtual void OnErrorOccurred(ErrorEventArgs e)
        {
            if (this.ErrorOccurred != null)
            {
                this.ErrorOccurred(this, e);
            }
        }



    }
}
