using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract.Repositories;
using DataAccessLayer.Concrete.EntityFramework.Repositories;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IAboutService>().To<AboutManager>().InSingletonScope();
            Bind<IAboutDal>().To<EfAboutRepository>().InSingletonScope();

            Bind<IBlogService>().To<BlogManager>().InSingletonScope();
            Bind<IBlogDal>().To<EfBlogRepository>().InSingletonScope();

            Bind<ICategoryService>().To<CategoryManager>().InSingletonScope();
            Bind<ICategoryDal>().To<EfCategoryRepository>().InSingletonScope();

            Bind<ICommentService>().To<CommentManager>().InSingletonScope();
            Bind<ICommentDal>().To<EfCommentRepository>().InSingletonScope();

            Bind<IContactService>().To<ContactManager>().InSingletonScope();
            Bind<IContactDal>().To<EfContactRepository>().InSingletonScope();

            Bind<IMessageService>().To<MessageManager>().InSingletonScope();
            Bind<IMessageDal>().To<EfMessageRepository>().InSingletonScope();

            Bind<INewsletterService>().To<NewsletterManager>().InSingletonScope();
            Bind<INewsletterDal>().To<EfNewsletterRepository>().InSingletonScope();

            Bind<INotificationService>().To<NotificationManager>().InSingletonScope();
            Bind<INotificationDal>().To<EfNotificationRepository>().InSingletonScope();

            Bind<IStatisticService>().To<StatisticManager>().InSingletonScope();

            Bind<IWriterService>().To<WriterManager>().InSingletonScope();
            Bind<IWriterDal>().To<EfWriterRepository>().InSingletonScope();
        }
    }
}
