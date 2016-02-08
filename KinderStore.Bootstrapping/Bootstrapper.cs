using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinderStore.Bootstrapping
{
	public class Bootstrapper
	{
		private readonly IContainer _container;
		public Bootstrapper()
		{
			_container = ApplicationContext.Container;
			Initialize();
		}

		private void Initialize()
		{
			//_container.RegisterType<ILogger, Log4NetLogger>(LifeTime.ContainerControlled);
			//_container.RegisterType<ISugarConfigurationProvider, SugarConfigurationProvider>();
			//_container.RegisterType<ISuperlawyersConfigurationProvider, SuperlawyersConfigurationProvider>();
			//_container.RegisterType<ISugarRequestExecutor, SugarRequestExecutor>();
			//_container.RegisterType<ISugarRequestExecutorManager, SugarRequestExecutorManager>();
			//_container.RegisterType<ISugarApiClient, FailoverSugarApiClient>();
			//_container.RegisterType<ISugarUserRepository, SugarUserRepository>();
			//_container.RegisterType<IReferralManagerContextFactory, ReferralManagerContextFactory>();
			////_container.RegisterType<ILeadRepository, SugarLeadRepository>();
			//_container.RegisterType<ILeadRepository, LeadRepository>();
			//_container.RegisterType<ICompanyRepository, CompanyRepository>();
			//_container.RegisterType<INotificationRepository, NotificationRepository>();
			////_container.RegisterType<IReferralRepository, SugarReferralRepository>();
			//_container.RegisterType<IReferralRepository, ReferralRepository>();
			////_container.RegisterType<INoteRepository, SugarNoteRepository>();
			//_container.RegisterType<INoteRepository, NoteRepository>();
			//_container.RegisterType<IContactDataService, ContactDataService>();
			//_container.RegisterType<IProfileRepository, SuperLawyersProfileRepository>();
			//_container.RegisterType<ISuperLawyersAuthorizationHandler, SuperLawyersAuthorizationHandler>();
			//_container.RegisterType<IExpirationService, ExpirationService>();
			//_container.RegisterType<IProfileService, ProfileService>();
			//_container.RegisterType<IReferralService, ReferralService>();
			//_container.RegisterType<INotificationService, NotificationService>();
			//_container.RegisterType<IUserService, UserService>();
			//_container.RegisterType<ILeadService, LeadService>();
			//_container.RegisterType<INoteService, NoteService>();
			//
			//_container.RegisterType<INotificationWorker, NotificationWorker>(LifeTime.PerResolve);
			//
			//_container.RegisterInstance(new NotificationWorkerSettings());
		}
	}
}
