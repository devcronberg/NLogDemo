using NLog;
using System;

namespace LogDemo
{
    class Program
    {
        // https://nlog-project.org/
        private static Logger logger = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {

            logger.Trace("Trace...");
            logger.Debug("Debug...");
            logger.Info("Info...");
            logger.Warn("Warn...");
            logger.Error("Error...");

            try
            {
                string a = null;
                a.ToCharArray();
            }
            catch (Exception ex)
            {
                logger.Error(ex);                
            }

            logger.Fatal("Fatal...");

            Metode1();

            // Ekstra
            Metode1();
        }

        static void Metode1() {
            logger.Debug("I metode1");
            //
            logger.Debug("Ud af metode1");
        }
        
    }
}
