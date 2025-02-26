using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Orion.Domain.Models;
using Orion.Infrastructure.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Orion.Pages.Supervisor
{
    public class superProfileModel : PageModel
    {
        private readonly ISupervisorService _supervisorService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public superProfileModel(
            ISupervisorService supervisorService, IHttpContextAccessor httpContextAccessor
)
        {
            _httpContextAccessor = httpContextAccessor;
            _supervisorService = supervisorService;
        }

        [BindProperty(SupportsGet = true)]
        public List<Domain.Models.Supervisor> Supervisors { get; set; }
        public Domain.Models.Supervisor Supervisor { get; set; }

        public List<Freelancer> Freelancers { get; set; }
        public List<User> Users { get; set; }
        public List<Product> Products { get; set; }
        public int ProductsNum { get; set; }
        public int FreelancerNum { get; set; }
        public int SupervisorId { get; set; }
        public byte[]? SupervisorImg { get; set; }
        public string? SupervisorInfo { get; set; }
        public string? SupervisorName { get; set; }
        public ICollection<Freelancer?> SupervisorFreelancer { get; set; }
        //Freelancers = await _supervisorService.Getall( new CancellationToken()).tolist();


        public async Task<IActionResult> OnGetAsync()
        {
            var supervisorId = _httpContextAccessor.HttpContext.Session.GetInt32("SupervisorID");

            Supervisor = await _supervisorService.GetSupervisorAsync(supervisorId.GetValueOrDefault(), new CancellationToken());


            ProductsNum = Supervisor.Products.Count;
            FreelancerNum = Supervisor.Freelancers.Count;
            SupervisorImg = Supervisor.SupervisorPhoto;
            SupervisorInfo = Supervisor.SupervisorInfo;
            SupervisorId = Supervisor.EmployeeId;
            SupervisorName = Supervisor.Employee.User.FirstName;
            SupervisorFreelancer = Supervisor.Freelancers;
            return Page();
        }
    }
}
