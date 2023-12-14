using Dental_Clinic.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

public class IndexModel : PageModel
{
    private readonly ApplicationDbContext _context;

    public IndexModel(ApplicationDbContext context)
    {
        _context = context;
    }

    public IList<Patient> Patients { get; set; }

    public async Task OnGetAsync()
    {
        Patients = await _context.Patients.ToListAsync();
    }
}