using System;
using log4net;
using log4net.Config;

namespace KinderStore.Domain.Logging
{
	public class Log4NetLogger : ILogger
	{
		private ILog log;
		public Log4NetLogger()
		{
			XmlConfigurator.Configure();
			log = LogManager.GetLogger(string.Empty);
		}
		#region Debug
		public void Debug(object message)
		{
			log.Debug(message);
		}

		public void Debug(object message, Exception ex)
		{
			log.Debug(message, ex);
		}
		#endregion

		#region Error
		public void Error(object message)
		{
			log.Error(message);
		}

		public void Error(object message, Exception ex)
		{
			log.Error(message, ex);
		}
		#endregion

		#region Fatal
		public void Fatal(object message)
		{
			log.Fatal(message);
		}

		public void Fatal(object message, Exception ex)
		{
			log.Fatal(message, ex);
		}
		#endregion

		#region Info
		public void Info(object message)
		{
			log.Info(message);
		}

		public void Info(object message, Exception ex)
		{
			log.Info(message, ex);
		}
		#endregion

		#region Warning
		public void Warning(object message)
		{
			log.Warn(message);
		}

		public void Warning(object message, Exception ex)
		{
			log.Warn(message, ex);
		}
		#endregion
	}
}