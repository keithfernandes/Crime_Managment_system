using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjCRS.Models;
using System.ComponentModel.DataAnnotations;

namespace ProjCRS.Pages
{
    public class SearchCriminalsModel : PageModel
    {   
        private AppDbContext _context;


      public SearchCriminalsModel(AppDbContext context) {
            _context = context;
        }
        public void OnGet()
        {
            SearchCompleted = false;
        }
        
        [BindProperty]
        [Required]
    
        [StringLength(100, MinimumLength = 2, ErrorMessage = "2 - 100 characters only")]
           
        public string Search { get; set; }
        
        
        public bool SearchCompleted { get; set; }
        public ICollection<Criminal> SearchResults { get; set; }


        public void OnPost() {
           
            if (string.IsNullOrWhiteSpace(Search)) {
              
                return;
            }


            SearchResults = _context.Criminal
                                    .Include(x => x.CriminalActivities)
                                   
                               
                                    .Where(x => x.FirstName.ToLower().Contains(Search.ToLower()))
                                    .ToList();
            SearchCompleted = true;
        }



    }
}