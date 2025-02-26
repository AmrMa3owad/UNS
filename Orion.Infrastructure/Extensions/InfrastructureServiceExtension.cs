using Microsoft.Extensions.DependencyInjection;
using Orion.Infrastructure.Services;

namespace Orion.Infrastructure.Extentions
{
    public static class InfrastructureServiceExtension
    {
        public static void ConfigureInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IContactUsService, ContactUsService>();
            services.AddScoped<ICartService, CartService>();
            services.AddScoped<IAdminService, AdminService>();
            services.AddScoped<IAdvertisementService, AdvertisementService>();
            services.AddScoped<IBoothService, BoothService>();
            services.AddScoped<IBoothOrderService, BoothOrderService>();
            services.AddScoped<ICraftService, CraftService>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<ICustomerAdvertisementService, CustomerAdvertisementService>();
            services.AddScoped<ICustomerProductService, CustomerProductService>();
            services.AddScoped<IDeliveryService, DeliveryService>();
            services.AddScoped<IDeliveryOrderService, DeliveryOrderService>();
            services.AddScoped<IDeviceService, DeviceService>();
            services.AddScoped<IDonationService, DonationService>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IEventService, EventService>();
            services.AddScoped<IFeedbackService, FeedbackService>();
            services.AddScoped<IFreelancerService, FreelancerService>();
            services.AddScoped<IMaterialService, MaterialService>();
            services.AddScoped<IMaterialVendorService, MaterialVendorService>();
            services.AddScoped<IMentorService, MentorService>();
            services.AddScoped<IOfficeWorkerService, OfficeWorkerService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IOrphanageService, OrphanageService>();
            services.AddScoped<IPaymentService, PaymentService>();
            services.AddScoped<IPreCommunityService, PreCommunityService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ISponsorService, SponsorService>();
            services.AddScoped<ISponsorAdvertisementService, SponsorAdvertisementService>();
            services.AddScoped<ISupervisorService, SupervisorService>();
            services.AddScoped<IVendorService, VendorService>();
            services.AddScoped<IWebsiteService, WebsiteService>();
            services.AddScoped<ICategoriesService, CategoryService>();
        }
    }
}
