using AutoMapper;
using LeaveManagementWeb.Constants;
using LeaveManagementWeb.Contracts;
using LeaveManagementWeb.Data;
using LeaveManagementWeb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementWeb.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly UserManager<Employee> userManager;
        private readonly IMapper mapper;
        private readonly ILeaveAllocationRepository leaveAllocationRepository;
        private readonly ILeaveTypeRepository leaveTypeRepository;

        public EmployeesController(UserManager<Employee> userManager, IMapper mapper, ILeaveAllocationRepository leaveAllocationRepository, ILeaveTypeRepository leaveTypeRepository) /* We need to inject whatever we're using, hence we need to inject ILAR(The interface and not the implentation)*/
        {
            this.userManager = userManager;
            this.mapper = mapper;
            this.leaveAllocationRepository = leaveAllocationRepository;
            this.leaveTypeRepository = leaveTypeRepository;
        }
        // GET: EmployeesController
        public async Task<IActionResult> Index()
        {
            var employees = await userManager.GetUsersInRoleAsync(Roles.User);
            var model = mapper.Map<List<EmployeeListVM>>(employees);
            return View(model);
        }

        // GET: EmployeesController/ViewAllocations/employeeId
        public async Task<ActionResult> ViewAllocations(string id) /*Do all the logic inside the repositories and not the controller. For that we need to first update the contract andthen imple
                                                        implement the contract inside the repo*/
        {
            var model = await leaveAllocationRepository.GetEmployeeAllocations(id);
            return View(model);
        }
                
        // GET: EmployeesController/EditAllocation/5
        public async Task<ActionResult> EditAllocation(int id)
        {
            var model = await leaveAllocationRepository.GetEmployeeAllocation(id);
            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }

        // POST: EmployeesController/EditAllocation/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditAllocation(int id, LeaveAllocationEditVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if(await leaveAllocationRepository.UpdateEmployeeAllocation(model) == true)
                    {
                        return RedirectToAction(nameof(ViewAllocations), new { id = model.EmployeeId }); /*when giving params of an action onto the nameof function,
                                                                                                      the params will be inside a new {} instead of inside the action
                                                                                                      for eg. here it should've been ViewAllocations(model.EmployeeId)*/
                    }
                }

                    
            }
            catch(Exception ex)
            {
                ModelState.AddModelError(string.Empty, "An error has occured. Please try again later");                
            }
            /*Now the model only contains the things we post via form, i.e leaveId, EmployeeId and Number of days. We need employee name in the return view model. So we need to add that*/
            model.Employee = mapper.Map<EmployeeListVM>(await userManager.FindByIdAsync(model.EmployeeId));
            /*We also need the leavetype in the model*/
            model.LeaveType = mapper.Map<LeaveTypeVM>(await leaveTypeRepository.GetAsync(model.LeaveTypeId));
            return View(model);
        }

    }
}
