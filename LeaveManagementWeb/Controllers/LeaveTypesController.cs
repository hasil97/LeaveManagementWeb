using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LeaveManagementWeb.Data;
using AutoMapper;
using LeaveManagementWeb.Models;
using LeaveManagementWeb.Contracts;
using Microsoft.AspNetCore.Authorization;
using LeaveManagementWeb.Constants;

namespace LeaveManagementWeb.Controllers
{
    [Authorize(Roles = Roles.Administrator)]
    public class LeaveTypesController : Controller
    {
          /*The 'private' means this variable can only be accessed by this class and 'readonly' means this variable value can only be assigned once and that too
                                                          in constructor of this class.*/
        private readonly ILeaveTypeRepository leaveTypeRepository;
        private readonly IMapper mapper;

        public LeaveTypesController(/*ApplicationDbContext context*/ILeaveTypeRepository leaveTypeRepository,IMapper mapper)  /*These lines are basically dependency Injection. We are injecting an already existing database onto this class
                                                                    i.e ApplicationDbContext*/
        {
            //_context = context;
            this.leaveTypeRepository = leaveTypeRepository;
            this.mapper = mapper;
        }

        // GET: LeaveTypes
        public async Task<IActionResult> Index() /*Async and await basically is used to run multiple independent task parallely. 'async' 'Task<datatype to be returned>' 'await' These
                                                  three are mandatory for async to work. */
        {
              var leaveTypesVM = mapper.Map<List<LeaveTypeVM>>(await leaveTypeRepository.GetAllAsync());
              return View(leaveTypesVM); /*All async functions will end with '....Async()' and we need to prepend those functions with 'await'*/
        }

        // GET: LeaveTypes/Details/5
        public async Task<IActionResult> Details(int id)
        {

            var leaveType = await leaveTypeRepository.GetAsync(id);
                
            if (leaveType == null)
            {
                return NotFound();
            }
            var leaveTypeVM = mapper.Map<LeaveTypeVM>(leaveType);
            return View(leaveTypeVM);
        }

        // GET: LeaveTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LeaveTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(LeaveTypeVM leaveTypeVM)
        {
            if (ModelState.IsValid)
            {
                var leaveType = mapper.Map<LeaveType>(leaveTypeVM); 
                await leaveTypeRepository.AddAsync(leaveType);
                return RedirectToAction(nameof(Index));
            }
            return View(leaveTypeVM);
        }

        // GET: LeaveTypes/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var leaveType = await leaveTypeRepository.GetAsync(id);
            if (leaveType == null)
            {
                return NotFound();
            }
            var leaveTypeVM = mapper.Map<LeaveTypeVM>(leaveType);
            return View(leaveTypeVM);
        }

        // POST: LeaveTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,LeaveTypeVM leaveTypeVM)
        {
            if (id != leaveTypeVM.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var leaveType = mapper.Map<LeaveType>(leaveTypeVM);
                    await leaveTypeRepository.UpdateAsync(leaveType);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await leaveTypeRepository.Exists(leaveTypeVM.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(leaveTypeVM);
        }

        // GET: LeaveTypes/Delete/5
        /*public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.LeaveTypes == null)
            {
                return NotFound();
            }

            var leaveType = await _context.LeaveTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (leaveType == null)
            {
                return NotFound();
            }

            return View(leaveType);
        }*/

        // POST: LeaveTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int isd)
        {
            await leaveTypeRepository.DeleteAsync(isd);
            return RedirectToAction(nameof(Index));
        }

        /*private bool LeaveTypeExists(int id)
        {
          return _context.LeaveTypes.Any(e => e.Id == id);
        }*/ //leaveTypeRepository.Exists(id) does this job
    }
}
