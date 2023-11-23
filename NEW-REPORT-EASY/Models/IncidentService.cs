using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW_REPORT_EASY.Models
public class IncidentService
{
    private readonly AppDbContext _context;

    public IncidentService(AppDbContext context)
    {
        _context = context;
    }
}



